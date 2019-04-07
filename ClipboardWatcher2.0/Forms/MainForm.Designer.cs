namespace ClipboardWatcher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.dragVersion = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragTitle = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.dragLogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblExit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dragHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlContents = new System.Windows.Forms.Panel();
            this.TrayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showClipboardWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseClipboardWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlSide = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImages = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnText = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.TrayContextMenuStrip.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Interval = 10;
            this.tmrFadeIn.Tick += new System.EventHandler(this.tmrFadeIn_Tick);
            // 
            // dragVersion
            // 
            this.dragVersion.Fixed = true;
            this.dragVersion.Horizontal = true;
            this.dragVersion.TargetControl = null;
            this.dragVersion.Vertical = true;
            // 
            // dragTitle
            // 
            this.dragTitle.Fixed = true;
            this.dragTitle.Horizontal = true;
            this.dragTitle.TargetControl = this.lblTitle;
            this.dragTitle.Vertical = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(261, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 23);
            this.lblTitle.TabIndex = 81;
            this.lblTitle.Text = "ClipboardWatcher";
            // 
            // dragLogo
            // 
            this.dragLogo.Fixed = true;
            this.dragLogo.Horizontal = true;
            this.dragLogo.TargetControl = this.pbLogo;
            this.dragLogo.Vertical = true;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(166, 118);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlHeader.Controls.Add(this.lblVersion);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblMinimize);
            this.pnlHeader.Controls.Add(this.lblExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(166, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(704, 118);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(313, 83);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(75, 15);
            this.lblVersion.TabIndex = 83;
            this.lblVersion.Text = "Version x.x.x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "Keeps track of your clipboard";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Location = new System.Drawing.Point(661, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(21, 22);
            this.lblMinimize.TabIndex = 5;
            this.lblMinimize.Text = "- ";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Transparent;
            this.lblExit.Location = new System.Drawing.Point(682, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(22, 22);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // dragHeader
            // 
            this.dragHeader.Fixed = true;
            this.dragHeader.Horizontal = true;
            this.dragHeader.TargetControl = this.pnlHeader;
            this.dragHeader.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pnlContents
            // 
            this.pnlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContents.Location = new System.Drawing.Point(166, 118);
            this.pnlContents.Name = "pnlContents";
            this.pnlContents.Size = new System.Drawing.Size(704, 442);
            this.pnlContents.TabIndex = 5;
            // 
            // TrayContextMenuStrip
            // 
            this.TrayContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.TrayContextMenuStrip.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClipboardWatcherToolStripMenuItem,
            this.pauseClipboardWatcherToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TrayContextMenuStrip.Name = "TrayContextMenuStrip";
            this.TrayContextMenuStrip.ShowImageMargin = false;
            this.TrayContextMenuStrip.Size = new System.Drawing.Size(184, 70);
            this.TrayContextMenuStrip.Text = "ClipboardWatcher";
            // 
            // showClipboardWatcherToolStripMenuItem
            // 
            this.showClipboardWatcherToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showClipboardWatcherToolStripMenuItem.Name = "showClipboardWatcherToolStripMenuItem";
            this.showClipboardWatcherToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.showClipboardWatcherToolStripMenuItem.Text = "Show ClipboardWatcher";
            this.showClipboardWatcherToolStripMenuItem.Click += new System.EventHandler(this.showClipboardWatcherToolStripMenuItem_Click);
            // 
            // pauseClipboardWatcherToolStripMenuItem
            // 
            this.pauseClipboardWatcherToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pauseClipboardWatcherToolStripMenuItem.Name = "pauseClipboardWatcherToolStripMenuItem";
            this.pauseClipboardWatcherToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pauseClipboardWatcherToolStripMenuItem.Text = "Pause ClipboardWatcher";
            this.pauseClipboardWatcherToolStripMenuItem.Click += new System.EventHandler(this.pauseClipboardWatcherToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipText = "ClipboardWatcher";
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenuStrip;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "ClipboardWatcher";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSide.BackgroundImage")));
            this.pnlSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSide.Controls.Add(this.btnSettings);
            this.pnlSide.Controls.Add(this.btnHistory);
            this.pnlSide.Controls.Add(this.btnImages);
            this.pnlSide.Controls.Add(this.btnText);
            this.pnlSide.Controls.Add(this.pbLogo);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlSide.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlSide.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlSide.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Quality = 10;
            this.pnlSide.Size = new System.Drawing.Size(166, 560);
            this.pnlSide.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.DarkSeaGreen;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "     Settings";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledColor = System.Drawing.Color.White;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 0;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 50D;
            this.btnSettings.IsTab = true;
            this.btnSettings.Location = new System.Drawing.Point(0, 262);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnSettings.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(166, 48);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Activecolor = System.Drawing.Color.DarkSeaGreen;
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.BorderRadius = 0;
            this.btnHistory.ButtonText = "     History";
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.DisabledColor = System.Drawing.Color.White;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHistory.Iconimage")));
            this.btnHistory.Iconimage_right = null;
            this.btnHistory.Iconimage_right_Selected = null;
            this.btnHistory.Iconimage_Selected = null;
            this.btnHistory.IconMarginLeft = 0;
            this.btnHistory.IconMarginRight = 0;
            this.btnHistory.IconRightVisible = true;
            this.btnHistory.IconRightZoom = 0D;
            this.btnHistory.IconVisible = true;
            this.btnHistory.IconZoom = 50D;
            this.btnHistory.IsTab = true;
            this.btnHistory.Location = new System.Drawing.Point(0, 214);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnHistory.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHistory.selected = false;
            this.btnHistory.Size = new System.Drawing.Size(166, 48);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.Text = "     History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Textcolor = System.Drawing.Color.White;
            this.btnHistory.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnImages
            // 
            this.btnImages.Activecolor = System.Drawing.Color.DarkSeaGreen;
            this.btnImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImages.BorderRadius = 0;
            this.btnImages.ButtonText = "     Images";
            this.btnImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImages.DisabledColor = System.Drawing.Color.White;
            this.btnImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImages.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImages.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImages.Iconimage")));
            this.btnImages.Iconimage_right = null;
            this.btnImages.Iconimage_right_Selected = null;
            this.btnImages.Iconimage_Selected = null;
            this.btnImages.IconMarginLeft = 0;
            this.btnImages.IconMarginRight = 0;
            this.btnImages.IconRightVisible = true;
            this.btnImages.IconRightZoom = 0D;
            this.btnImages.IconVisible = true;
            this.btnImages.IconZoom = 50D;
            this.btnImages.IsTab = true;
            this.btnImages.Location = new System.Drawing.Point(0, 166);
            this.btnImages.Name = "btnImages";
            this.btnImages.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnImages.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnImages.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImages.selected = false;
            this.btnImages.Size = new System.Drawing.Size(166, 48);
            this.btnImages.TabIndex = 12;
            this.btnImages.Text = "     Images";
            this.btnImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImages.Textcolor = System.Drawing.Color.White;
            this.btnImages.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // btnText
            // 
            this.btnText.Activecolor = System.Drawing.Color.DarkSeaGreen;
            this.btnText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnText.BorderRadius = 0;
            this.btnText.ButtonText = "     Text";
            this.btnText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnText.DisabledColor = System.Drawing.Color.White;
            this.btnText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnText.Iconcolor = System.Drawing.Color.Transparent;
            this.btnText.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnText.Iconimage")));
            this.btnText.Iconimage_right = null;
            this.btnText.Iconimage_right_Selected = null;
            this.btnText.Iconimage_Selected = null;
            this.btnText.IconMarginLeft = 0;
            this.btnText.IconMarginRight = 0;
            this.btnText.IconRightVisible = true;
            this.btnText.IconRightZoom = 0D;
            this.btnText.IconVisible = true;
            this.btnText.IconZoom = 50D;
            this.btnText.IsTab = true;
            this.btnText.Location = new System.Drawing.Point(0, 118);
            this.btnText.Name = "btnText";
            this.btnText.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnText.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnText.OnHoverTextColor = System.Drawing.Color.White;
            this.btnText.selected = true;
            this.btnText.Size = new System.Drawing.Size(166, 48);
            this.btnText.TabIndex = 11;
            this.btnText.Text = "     Text";
            this.btnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnText.Textcolor = System.Drawing.Color.White;
            this.btnText.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 560);
            this.Controls.Add(this.pnlContents);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ClipboardWatcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.TrayContextMenuStrip.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSide;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistory;
        private Bunifu.Framework.UI.BunifuFlatButton btnImages;
        private Bunifu.Framework.UI.BunifuFlatButton btnText;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMinimize;
        private Bunifu.Framework.UI.BunifuCustomLabel lblExit;
        private System.Windows.Forms.Timer tmrFadeIn;
        private Bunifu.Framework.UI.BunifuDragControl dragVersion;
        private Bunifu.Framework.UI.BunifuDragControl dragTitle;
        private Bunifu.Framework.UI.BunifuDragControl dragLogo;
        private Bunifu.Framework.UI.BunifuDragControl dragHeader;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContents;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showClipboardWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseClipboardWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Label lblVersion;
    }
}

