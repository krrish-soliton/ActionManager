using GoLib.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GoActionManager
{
    public partial class ActionContainer : MaterialControl
    {
        public ActionContainer()
        {
            InitializeComponent();
        }

        private readonly List<TextInputControl> textInputControls = new List<TextInputControl>();

        public ActionData ActionSaveData { get; private set; } = new ActionData();

        public event EventHandler DeleteActivated;
        private bool isInternal;
        public void SetActionData(ActionData actionData)
        {
            ActionSaveData = actionData;
            isInternal = true;
            var actionHolder = ActionHolder.ActionTypes.FirstOrDefault(i => i.ActionName == actionData.ActionName);
            ActionTypeCombo.SelectedItem = actionHolder;
            foreach (var data in actionData.Datas)
            {
                var textInput = textInputControls.FirstOrDefault(i => i.InputKey == data.Key);
                if (textInput != null) textInput.Text = data.Value;
            }
            isInternal = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (var action in ActionHolder.ActionTypes)
            {
                ActionTypeCombo.Items.Add(action);
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            TextContainer.Controls.Clear();
            if (ActionTypeCombo.SelectedItem is ActionType actionType)
            {
                ActionSaveData.ActionName = actionType.ActionName;
                int i = 0;
                foreach (var action in actionType.TextInfos)
                {
                    if (textInputControls.Count <= i)
                    {
                        var newInputControl = new TextInputControl() { Dock = DockStyle.Top };
                        newInputControl.ValueChanged += OnControlValueChanged;
                        textInputControls.Add(newInputControl);
                    }
                    var inputControl = textInputControls[i];
                    i++;
                    inputControl.InputKey = action.Key;
                    inputControl.Text = "";
                    inputControl.TextHint = action.Hint;
                    inputControl.IsMultiSelect = action.IsMultiSelect;
                    inputControl.HasFile = action.HasFileSelection;
                    inputControl.IsFolder = action.IsFolder;
                    inputControl.IsSave = action.IsSave;
                    TextContainer.Controls.Add(inputControl);
                    inputControl.BringToFront();
                }
                if (textInputControls.Count > 0)
                    Height = TopContainer.Height + TextContainer.Controls.Count * textInputControls[0].Height + 4;
            }
        }

        private void OnControlValueChanged(object sender, EventArgs e)
        {
            if (isInternal) return;
            if (sender is TextInputControl textInputControl)
            {
                ActionSaveData.SetData(textInputControl.InputKey, textInputControl.Text);
            }
        }

        private void OnDeleteClicked(object sender, EventArgs e) => DeleteActivated?.Invoke(this, EventArgs.Empty);

        private void OnPlayClicked(object sender, EventArgs e)
        {

        }
    }
}
