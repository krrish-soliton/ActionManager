namespace GoActionManager
{
    partial class TextInputControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileTxtBox = new GoLib.UI.MaterialTextBox();
            this.FileOpenBtn = new GoLib.UI.MaterialCircleButton();
            this.FileOpener = new System.Windows.Forms.OpenFileDialog();
            this.FolderOpener = new System.Windows.Forms.FolderBrowserDialog();
            this.FileSaver = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FileTxtBox
            // 
            this.FileTxtBox.CaretColor = System.Drawing.Color.Empty;
            this.FileTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTxtBox.HideSelection = true;
            this.FileTxtBox.HintText = "Enter Text";
            this.FileTxtBox.Location = new System.Drawing.Point(0, 0);
            this.FileTxtBox.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.FileTxtBox.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.FileTxtBox.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileTxtBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.FileTxtBox.Name = "FileTxtBox";
            this.FileTxtBox.Size = new System.Drawing.Size(509, 45);
            this.FileTxtBox.TabIndex = 0;
            this.FileTxtBox.TextChanged += new System.EventHandler(this.OnFileTxtChanged);
            // 
            // FileOpenBtn
            // 
            this.FileOpenBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileOpenBtn.DrawBorder = true;
            this.FileOpenBtn.IconDisplayType = GoLib.UI.IconType.FileOpen;
            this.FileOpenBtn.IconString = "FileOpen";
            this.FileOpenBtn.Location = new System.Drawing.Point(509, 0);
            this.FileOpenBtn.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.FileOpenBtn.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.FileOpenBtn.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileOpenBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.FileOpenBtn.Name = "FileOpenBtn";
            this.FileOpenBtn.Size = new System.Drawing.Size(45, 45);
            this.FileOpenBtn.TabIndex = 5;
            this.FileOpenBtn.Text = "materialCircleButton2";
            this.FileOpenBtn.Click += new System.EventHandler(this.OnFileClicked);
            // 
            // FileSaver
            // 
            this.FileSaver.AddExtension = false;
            this.FileSaver.RestoreDirectory = true;
            // 
            // TextInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileTxtBox);
            this.Controls.Add(this.FileOpenBtn);
            this.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.Name = "TextInputControl";
            this.Size = new System.Drawing.Size(554, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private GoLib.UI.MaterialTextBox FileTxtBox;
        private GoLib.UI.MaterialCircleButton FileOpenBtn;
        private System.Windows.Forms.OpenFileDialog FileOpener;
        private System.Windows.Forms.FolderBrowserDialog FolderOpener;
        private System.Windows.Forms.SaveFileDialog FileSaver;
    }
}
