using GoLib.UI;
using System;
using System.Windows.Forms;

namespace GoActionManager
{
    public partial class TextInputControl : MaterialControl
    {
        public TextInputControl()
        {
            InitializeComponent();
            Text = "";
        }

        public event EventHandler ValueChanged;

        public string TextHint
        {
            get { return FileTxtBox.HintText; }
            set { FileTxtBox.HintText = value; }
        }

        public string InputKey { get; set; }

        public override string Text
        {
            get { return FileTxtBox.Text; }
            set
            {
                base.Text = value;
                FileTxtBox.Text = value;
            }
        }

        public bool IsFolder { get; set; }

        public bool IsSave { get; set; }

        public bool HasFile
        {
            get { return FileOpenBtn.Visible; }
            set { FileOpenBtn.Visible = value; }
        }

        public bool IsMultiSelect
        {
            get
            {
                return FileOpener.Multiselect;
            }
            set
            {
                FileOpener.Multiselect = value;
            }
        }

        private void OnFileClicked(object sender, EventArgs e)
        {
            if (IsSave)
            {
                if (FileSaver.ShowDialog(this) == DialogResult.OK)
                {
                    FileTxtBox.Text = FileSaver.FileName;
                }
                return;
            }
            if (IsFolder)
            {
                if (FolderOpener.ShowDialog(this) == DialogResult.OK)
                {
                    FileTxtBox.Text = FolderOpener.SelectedPath;
                }
                return;
            }
            if (FileOpener.ShowDialog(this) == DialogResult.OK)
            {
                FileTxtBox.Text = string.Join("|", FileOpener.FileNames);
            }
        }

        private void OnFileTxtChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
