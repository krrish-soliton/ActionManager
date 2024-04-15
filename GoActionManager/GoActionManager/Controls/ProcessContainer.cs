using GoLib.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GoActionManager
{
    public partial class ProcessContainer : MaterialControl
    {
        public ProcessContainer()
        {
            InitializeComponent();
            actualHeight = TopPanel.Height + 2;
        }

        private readonly List<ActionContainer> Actions = new List<ActionContainer>();
        public event EventHandler DeleteActivated;
        private int actualHeight;
        public void SetProcessContainer(ProcessContainerData data)
        {
            Text = data.Name;
            foreach (var action in data.Actions)
            {
                var container = CreateContainer();
                container.SetActionData(action);
            }
        }

        public bool IsOpen { get; set; } = true;

        public ProcessContainerData GetProcessContainerData()
        {
            return new ProcessContainerData
            {
                Name = Text,
                Actions = Actions.Select(i => i.ActionSaveData).ToList()
            };
        }

        private void OnNewClicked(object sender, EventArgs e)
        {
            CreateContainer();
        }

        private ActionContainer CreateContainer()
        {
            var container = new ActionContainer();
            container.DeleteActivated += OnContainerDeleted;
            container.Resize += OnActionContainerResize;
            container.Dock = DockStyle.Top;
            ControlsContainer.Controls.Add(container);
            Actions.Add(container);
            OnActionContainerResize(container, EventArgs.Empty);
            return container;
        }

        private void OnActionContainerResize(object sender, EventArgs e)
        {
            actualHeight = TopPanel.Height + 4 + Actions.Sum(i => i.Height);
            if (IsOpen) Height = actualHeight;
        }

        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                HeadingLbl.Text = value;
            }
        }

        private void OnContainerDeleted(object sender, EventArgs e)
        {
            if (MaterialMessageBox.Show("Sure you want to delete?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sender is ActionContainer container)
                {
                    container.Resize -= OnActionContainerResize;
                    container.DeleteActivated -= OnContainerDeleted;
                    ControlsContainer.Controls.Remove(container);
                    Actions.Remove(container);
                    OnActionContainerResize(container, e);
                }
            }
        }

        private void OnPlayBtnClicked(object sender, EventArgs e)
        {
            foreach (var action in Actions)
            {
                var actionData = ActionHolder.ActionTypes.FirstOrDefault(i => i.ActionName == action.ActionSaveData.ActionName);
                var actionResult = actionData.Execute(action.ActionSaveData);
                if (!actionResult)
                {
                    MaterialMessageBox.Show($"Error in processing : {actionResult.Message}");
                    return;
                }
            }
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            DeleteActivated?.Invoke(this, e);
        }

        private void OnExpandClicked(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                IsOpen = false;
                Height = TopPanel.Height + 2;
                ExpandBtn.IconDisplayType = IconType.KeyboardArrowRight;
            }
            else
            {
                IsOpen = true;
                Height = actualHeight;
                ExpandBtn.IconDisplayType = IconType.KeyboardArrowDown;
            }
        }
    }
}
