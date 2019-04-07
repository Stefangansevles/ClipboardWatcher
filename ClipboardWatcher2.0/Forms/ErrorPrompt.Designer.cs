namespace ClipboardWatcher
{
    partial class ErrorPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorPrompt));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlMainGradient = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblException = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooterButtons = new System.Windows.Forms.Panel();
            this.btnYes = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMainGradient.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlFooterButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlMainGradient;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlMainGradient
            // 
            this.pnlMainGradient.AutoSize = true;
            this.pnlMainGradient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlMainGradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMainGradient.BackgroundImage")));
            this.pnlMainGradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainGradient.Controls.Add(this.panel1);
            this.pnlMainGradient.Controls.Add(this.pbIcon);
            this.pnlMainGradient.Controls.Add(this.lblTitle);
            this.pnlMainGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainGradient.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlMainGradient.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlMainGradient.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlMainGradient.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.pnlMainGradient.Location = new System.Drawing.Point(0, 0);
            this.pnlMainGradient.Name = "pnlMainGradient";
            this.pnlMainGradient.Quality = 10;
            this.pnlMainGradient.Size = new System.Drawing.Size(584, 195);
            this.pnlMainGradient.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblException);
            this.panel1.Location = new System.Drawing.Point(219, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 142);
            this.panel1.TabIndex = 12;
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.BackColor = System.Drawing.Color.Transparent;
            this.lblException.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblException.ForeColor = System.Drawing.Color.White;
            this.lblException.Location = new System.Drawing.Point(5, 3);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(86, 15);
            this.lblException.TabIndex = 10;
            this.lblException.Text = "stacktrace here";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcon.Image = global::ClipboardWatcher.Properties.Resources.thisisfineR;
            this.pbIcon.Location = new System.Drawing.Point(12, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(194, 89);
            this.pbIcon.TabIndex = 11;
            this.pbIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(215, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 23);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Aww Damn! An error has occured";
            // 
            // pnlFooterButtons
            // 
            this.pnlFooterButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.pnlFooterButtons.Controls.Add(this.btnYes);
            this.pnlFooterButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterButtons.Location = new System.Drawing.Point(0, 195);
            this.pnlFooterButtons.Name = "pnlFooterButtons";
            this.pnlFooterButtons.Size = new System.Drawing.Size(584, 51);
            this.pnlFooterButtons.TabIndex = 4;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.btnYes.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(98)))));
            this.btnYes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(185)))), ((int)(((byte)(98)))));
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Image = null;
            this.btnYes.ImagePosition = 12;
            this.btnYes.ImageZoom = 50;
            this.btnYes.LabelPosition = 22;
            this.btnYes.LabelText = "Close";
            this.btnYes.Location = new System.Drawing.Point(477, 11);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(79, 30);
            this.btnYes.TabIndex = 87;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ErrorPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 246);
            this.Controls.Add(this.pnlMainGradient);
            this.Controls.Add(this.pnlFooterButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorPrompt";
            this.Text = "ErrorPrompt";
            this.pnlMainGradient.ResumeLayout(false);
            this.pnlMainGradient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlFooterButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMainGradient;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooterButtons;
        private Bunifu.Framework.UI.BunifuTileButton btnYes;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblException;
    }
}