namespace GoActionManager
{
    partial class ActionManagerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionManagerForm));
            this.MainPanel = new GoLib.UI.MaterialPanel();
            this.AddContainer = new GoLib.UI.MaterialPanel();
            this.NameBx = new GoLib.UI.MaterialTextBox();
            this.AddActionBtn = new GoLib.UI.MaterialCircleButton();
            this.LoadBtn = new GoLib.UI.MaterialCircleButton();
            this.DownloadBtn = new GoLib.UI.MaterialCircleButton();
            this.FileSaver = new System.Windows.Forms.SaveFileDialog();
            this.FileOpener = new System.Windows.Forms.OpenFileDialog();
            this.HeadingPanel.SuspendLayout();
            this.BottomResizePanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.HeadingContainer.SuspendLayout();
            this.AddContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.MaterialResource.UseParentPalette = true;
            this.HeadingPanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.HeadingPanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.HeadingPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.HeadingPanel.Size = new System.Drawing.Size(821, 30);
            // 
            // LeftResizePanel
            // 
            this.LeftResizePanel.MaterialResource.InvertColorPalette = true;
            this.LeftResizePanel.MaterialResource.UseParentPalette = true;
            this.LeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.LeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.LeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.LeftResizePanel.Size = new System.Drawing.Size(3, 639);
            // 
            // BottomResizePanel
            // 
            this.BottomResizePanel.Location = new System.Drawing.Point(3, 636);
            this.BottomResizePanel.MaterialResource.InvertColorPalette = true;
            this.BottomResizePanel.MaterialResource.UseParentPalette = true;
            this.BottomResizePanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.BottomResizePanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.BottomResizePanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.BottomResizePanel.Size = new System.Drawing.Size(821, 3);
            // 
            // RightResizePanel
            // 
            this.RightResizePanel.Location = new System.Drawing.Point(824, 0);
            this.RightResizePanel.MaterialResource.InvertColorPalette = true;
            this.RightResizePanel.MaterialResource.UseParentPalette = true;
            this.RightResizePanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.RightResizePanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.RightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.RightResizePanel.Size = new System.Drawing.Size(3, 639);
            // 
            // TopResizePanel
            // 
            this.TopResizePanel.MaterialResource.InvertColorPalette = true;
            this.TopResizePanel.MaterialResource.UseParentPalette = true;
            this.TopResizePanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.TopResizePanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.TopResizePanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TopResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.TopResizePanel.Size = new System.Drawing.Size(821, 3);
            // 
            // BottomLeftResizePanel
            // 
            this.BottomLeftResizePanel.MaterialResource.InvertColorPalette = true;
            this.BottomLeftResizePanel.MaterialResource.UseParentPalette = true;
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomLeftResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            // 
            // BottomRightResizePanel
            // 
            this.BottomRightResizePanel.Location = new System.Drawing.Point(816, 0);
            this.BottomRightResizePanel.MaterialResource.InvertColorPalette = true;
            this.BottomRightResizePanel.MaterialResource.UseParentPalette = true;
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BottomRightResizePanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            // 
            // CloseToTrayIconBtn
            // 
            this.CloseToTrayIconBtn.MaterialResource.InvertColorPalette = true;
            this.CloseToTrayIconBtn.MaterialResource.UseParentPalette = true;
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseToTrayIconBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            // 
            // IconBox
            // 
            this.IconBox.Icon = ((System.Drawing.Icon)(resources.GetObject("IconBox.Icon")));
            this.IconBox.Location = new System.Drawing.Point(267, 0);
            this.IconBox.MaterialResource.InvertColorPalette = true;
            this.IconBox.MaterialResource.UseParentPalette = true;
            this.IconBox.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.IconBox.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.IconBox.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconBox.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconBox.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.IconBox.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconBox.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconBox.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.IconBox.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.IconBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.IconBox.Size = new System.Drawing.Size(30, 30);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.MaterialResource.ColorPaletteName = "";
            this.HeadingLabel.MaterialResource.InvertColorPalette = true;
            this.HeadingLabel.MaterialResource.UseParentPalette = true;
            this.HeadingLabel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.HeadingLabel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.HeadingLabel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.HeadingLabel.Size = new System.Drawing.Size(701, 30);
            this.HeadingLabel.Text = "Action Processor";
            // 
            // IconHeadingGap
            // 
            this.IconHeadingGap.MaterialResource.UseParentPalette = true;
            this.IconHeadingGap.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.IconHeadingGap.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.IconHeadingGap.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconHeadingGap.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Location = new System.Drawing.Point(731, 0);
            this.ButtonsPanel.MaterialResource.InvertColorPalette = true;
            this.ButtonsPanel.MaterialResource.UseParentPalette = true;
            this.ButtonsPanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.ButtonsPanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.ButtonsPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonsPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.ButtonsPanel.Size = new System.Drawing.Size(90, 30);
            // 
            // HeadingContainer
            // 
            this.HeadingContainer.MaterialResource.InvertColorPalette = true;
            this.HeadingContainer.MaterialResource.UseParentPalette = true;
            this.HeadingContainer.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.HeadingContainer.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.HeadingContainer.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeadingContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.HeadingContainer.Size = new System.Drawing.Size(731, 30);
            // 
            // HeadingAlignTimer
            // 
            this.HeadingAlignTimer.Enabled = true;
            // 
            // IconPanel
            // 
            this.IconPanel.MaterialResource.InvertColorPalette = true;
            this.IconPanel.MaterialResource.UseParentPalette = true;
            this.IconPanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.IconPanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.IconPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.IconPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconPanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            // 
            // CustomDataPanel
            // 
            this.CustomDataPanel.Location = new System.Drawing.Point(731, 0);
            this.CustomDataPanel.MaterialResource.InvertColorPalette = true;
            this.CustomDataPanel.MaterialResource.UseParentPalette = true;
            this.CustomDataPanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.CustomDataPanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.CustomDataPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomDataPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BorderRadius = ((byte)(0));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 82);
            this.MainPanel.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.MainPanel.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.MainPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MainPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MainPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.MainPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MainPanel.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MainPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(821, 554);
            this.MainPanel.TabIndex = 14;
            // 
            // AddContainer
            // 
            this.AddContainer.BorderRadius = ((byte)(0));
            this.AddContainer.Controls.Add(this.NameBx);
            this.AddContainer.Controls.Add(this.AddActionBtn);
            this.AddContainer.Controls.Add(this.LoadBtn);
            this.AddContainer.Controls.Add(this.DownloadBtn);
            this.AddContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddContainer.DrawBorder = true;
            this.AddContainer.Location = new System.Drawing.Point(3, 33);
            this.AddContainer.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.AddContainer.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.AddContainer.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddContainer.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddContainer.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.AddContainer.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddContainer.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddContainer.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddContainer.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.AddContainer.Name = "AddContainer";
            this.AddContainer.Padding = new System.Windows.Forms.Padding(2);
            this.AddContainer.Size = new System.Drawing.Size(821, 49);
            this.AddContainer.TabIndex = 15;
            // 
            // NameBx
            // 
            this.NameBx.CaretColor = System.Drawing.Color.Empty;
            this.NameBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameBx.HideSelection = true;
            this.NameBx.HintText = "Enter Execute Name";
            this.NameBx.Location = new System.Drawing.Point(2, 2);
            this.NameBx.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.NameBx.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.NameBx.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NameBx.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NameBx.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.NameBx.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NameBx.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NameBx.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.NameBx.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.NameBx.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameBx.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.NameBx.Name = "NameBx";
            this.NameBx.Size = new System.Drawing.Size(682, 44);
            this.NameBx.TabIndex = 2;
            // 
            // AddActionBtn
            // 
            this.AddActionBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddActionBtn.DrawBorder = true;
            this.AddActionBtn.IconString = "Add";
            this.AddActionBtn.Location = new System.Drawing.Point(684, 2);
            this.AddActionBtn.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.AddActionBtn.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.AddActionBtn.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddActionBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.AddActionBtn.Name = "AddActionBtn";
            this.AddActionBtn.Size = new System.Drawing.Size(45, 45);
            this.AddActionBtn.TabIndex = 1;
            this.AddActionBtn.Text = "materialCircleButton1";
            this.AddActionBtn.Click += new System.EventHandler(this.OnAddClicked);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoadBtn.DrawBorder = true;
            this.LoadBtn.IconDisplayType = GoLib.UI.IconType.FileOpen;
            this.LoadBtn.IconString = "FileOpen";
            this.LoadBtn.Location = new System.Drawing.Point(729, 2);
            this.LoadBtn.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.LoadBtn.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.LoadBtn.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LoadBtn.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LoadBtn.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.LoadBtn.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LoadBtn.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LoadBtn.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(45, 45);
            this.LoadBtn.TabIndex = 3;
            this.LoadBtn.Text = "materialCircleButton1";
            this.LoadBtn.Click += new System.EventHandler(this.OnLoadClicked);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DownloadBtn.DrawBorder = true;
            this.DownloadBtn.IconDisplayType = GoLib.UI.IconType.ArrowDownBold;
            this.DownloadBtn.IconString = "ArrowDownBold";
            this.DownloadBtn.Location = new System.Drawing.Point(774, 2);
            this.DownloadBtn.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.DownloadBtn.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.DownloadBtn.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.PrimaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(45, 45);
            this.DownloadBtn.TabIndex = 4;
            this.DownloadBtn.Text = "materialCircleButton1";
            this.DownloadBtn.Click += new System.EventHandler(this.OnDownloadClicked);
            // 
            // FileSaver
            // 
            this.FileSaver.Filter = "JsonFile|*.json";
            // 
            // FileOpener
            // 
            this.FileOpener.Filter = "JsonFiles|*.json";
            // 
            // ActionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 639);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.AddContainer);
            this.MaterialResource.UserColorPalette.DisabledColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.DisabledColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.MaterialResource.UserColorPalette.DisabledColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
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
            this.Name = "ActionManagerForm";
            this.ShowIcon = false;
            this.Text = "Action Processor";
            this.Controls.SetChildIndex(this.RightResizePanel, 0);
            this.Controls.SetChildIndex(this.LeftResizePanel, 0);
            this.Controls.SetChildIndex(this.BottomResizePanel, 0);
            this.Controls.SetChildIndex(this.TopResizePanel, 0);
            this.Controls.SetChildIndex(this.HeadingPanel, 0);
            this.Controls.SetChildIndex(this.AddContainer, 0);
            this.Controls.SetChildIndex(this.MainPanel, 0);
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            this.BottomResizePanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.HeadingContainer.ResumeLayout(false);
            this.AddContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GoLib.UI.MaterialPanel MainPanel;
        private GoLib.UI.MaterialPanel AddContainer;
        private GoLib.UI.MaterialCircleButton AddActionBtn;
        private GoLib.UI.MaterialTextBox NameBx;
        private GoLib.UI.MaterialCircleButton LoadBtn;
        private GoLib.UI.MaterialCircleButton DownloadBtn;
        private System.Windows.Forms.SaveFileDialog FileSaver;
        private System.Windows.Forms.OpenFileDialog FileOpener;
    }
}

