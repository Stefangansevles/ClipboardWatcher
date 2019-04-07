namespace ClipboardWatcher
{ 
    partial class UCHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHistory));
            this.lvImageFiles = new System.Windows.Forms.ListView();
            this.chImageFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlDateFilter = new System.Windows.Forms.Panel();
            this.cbFilterDay = new System.Windows.Forms.ComboBox();
            this.cbFilterMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterYear = new System.Windows.Forms.ComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnImageHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTextHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlImages = new System.Windows.Forms.Panel();
            this.imageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlText = new System.Windows.Forms.Panel();
            this.lvCopiedText = new System.Windows.Forms.ListView();
            this.chText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlDateFilter.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.imageContextMenuStrip.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvImageFiles
            // 
            this.lvImageFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chImageFile});
            this.lvImageFiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvImageFiles.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lvImageFiles.FullRowSelect = true;
            this.lvImageFiles.Location = new System.Drawing.Point(582, 0);
            this.lvImageFiles.Name = "lvImageFiles";
            this.lvImageFiles.Size = new System.Drawing.Size(122, 442);
            this.lvImageFiles.TabIndex = 1;
            this.lvImageFiles.UseCompatibleStateImageBehavior = false;
            this.lvImageFiles.View = System.Windows.Forms.View.Details;
            this.lvImageFiles.SelectedIndexChanged += new System.EventHandler(this.lvImageFiles_SelectedIndexChanged);
            this.lvImageFiles.DoubleClick += new System.EventHandler(this.lvImageFiles_DoubleClick);
            this.lvImageFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvImageFiles_KeyDown);
            this.lvImageFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvImageFiles_KeyUp);
            this.lvImageFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvImageFiles_MouseClick);
            // 
            // chImageFile
            // 
            this.chImageFile.Text = "Image";
            this.chImageFile.Width = 105;
            // 
            // pnlDateFilter
            // 
            this.pnlDateFilter.Controls.Add(this.cbFilterDay);
            this.pnlDateFilter.Controls.Add(this.cbFilterMonth);
            this.pnlDateFilter.Controls.Add(this.label1);
            this.pnlDateFilter.Controls.Add(this.cbFilterYear);
            this.pnlDateFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDateFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlDateFilter.Name = "pnlDateFilter";
            this.pnlDateFilter.Size = new System.Drawing.Size(582, 57);
            this.pnlDateFilter.TabIndex = 2;
            // 
            // cbFilterDay
            // 
            this.cbFilterDay.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.cbFilterDay.FormattingEnabled = true;
            this.cbFilterDay.Location = new System.Drawing.Point(227, 24);
            this.cbFilterDay.Name = "cbFilterDay";
            this.cbFilterDay.Size = new System.Drawing.Size(103, 24);
            this.cbFilterDay.TabIndex = 3;
            this.cbFilterDay.SelectedIndexChanged += new System.EventHandler(this.cbFilterDay_SelectedIndexChanged);
            // 
            // cbFilterMonth
            // 
            this.cbFilterMonth.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.cbFilterMonth.FormattingEnabled = true;
            this.cbFilterMonth.Location = new System.Drawing.Point(118, 24);
            this.cbFilterMonth.Name = "cbFilterMonth";
            this.cbFilterMonth.Size = new System.Drawing.Size(103, 24);
            this.cbFilterMonth.TabIndex = 2;
            this.cbFilterMonth.SelectedIndexChanged += new System.EventHandler(this.cbFilterMonth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter options";
            // 
            // cbFilterYear
            // 
            this.cbFilterYear.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.cbFilterYear.FormattingEnabled = true;
            this.cbFilterYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFilterYear.Location = new System.Drawing.Point(9, 24);
            this.cbFilterYear.Name = "cbFilterYear";
            this.cbFilterYear.Size = new System.Drawing.Size(103, 24);
            this.cbFilterYear.TabIndex = 0;
            this.cbFilterYear.SelectedIndexChanged += new System.EventHandler(this.cbFilterYear_SelectedIndexChanged);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnImageHistory);
            this.pnlFooter.Controls.Add(this.btnTextHistory);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 397);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(582, 45);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnImageHistory
            // 
            this.btnImageHistory.Activecolor = System.Drawing.Color.DarkSeaGreen;
            this.btnImageHistory.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnImageHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImageHistory.BorderRadius = 0;
            this.btnImageHistory.ButtonText = "     Image history";
            this.btnImageHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageHistory.DisabledColor = System.Drawing.Color.White;
            this.btnImageHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImageHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImageHistory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImageHistory.Iconimage")));
            this.btnImageHistory.Iconimage_right = null;
            this.btnImageHistory.Iconimage_right_Selected = null;
            this.btnImageHistory.Iconimage_Selected = null;
            this.btnImageHistory.IconMarginLeft = 0;
            this.btnImageHistory.IconMarginRight = 0;
            this.btnImageHistory.IconRightVisible = true;
            this.btnImageHistory.IconRightZoom = 0D;
            this.btnImageHistory.IconVisible = true;
            this.btnImageHistory.IconZoom = 50D;
            this.btnImageHistory.IsTab = true;
            this.btnImageHistory.Location = new System.Drawing.Point(166, 0);
            this.btnImageHistory.Name = "btnImageHistory";
            this.btnImageHistory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnImageHistory.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnImageHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImageHistory.selected = true;
            this.btnImageHistory.Size = new System.Drawing.Size(166, 45);
            this.btnImageHistory.TabIndex = 15;
            this.btnImageHistory.Text = "     Image history";
            this.btnImageHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImageHistory.Textcolor = System.Drawing.Color.White;
            this.btnImageHistory.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageHistory.Click += new System.EventHandler(this.btnImageHistory_Click);
            // 
            // btnTextHistory
            // 
            this.btnTextHistory.Activecolor = System.Drawing.Color.DarkSeaGreen;
            this.btnTextHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnTextHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTextHistory.BorderRadius = 0;
            this.btnTextHistory.ButtonText = "     Text history";
            this.btnTextHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTextHistory.DisabledColor = System.Drawing.Color.White;
            this.btnTextHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTextHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTextHistory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTextHistory.Iconimage")));
            this.btnTextHistory.Iconimage_right = null;
            this.btnTextHistory.Iconimage_right_Selected = null;
            this.btnTextHistory.Iconimage_Selected = null;
            this.btnTextHistory.IconMarginLeft = 0;
            this.btnTextHistory.IconMarginRight = 0;
            this.btnTextHistory.IconRightVisible = true;
            this.btnTextHistory.IconRightZoom = 0D;
            this.btnTextHistory.IconVisible = true;
            this.btnTextHistory.IconZoom = 50D;
            this.btnTextHistory.IsTab = true;
            this.btnTextHistory.Location = new System.Drawing.Point(0, 0);
            this.btnTextHistory.Name = "btnTextHistory";
            this.btnTextHistory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(82)))));
            this.btnTextHistory.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btnTextHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTextHistory.selected = false;
            this.btnTextHistory.Size = new System.Drawing.Size(166, 45);
            this.btnTextHistory.TabIndex = 14;
            this.btnTextHistory.Text = "     Text history";
            this.btnTextHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextHistory.Textcolor = System.Drawing.Color.White;
            this.btnTextHistory.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextHistory.Click += new System.EventHandler(this.btnTextHistory_Click);
            // 
            // pnlImages
            // 
            this.pnlImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImages.Location = new System.Drawing.Point(0, 57);
            this.pnlImages.Name = "pnlImages";
            this.pnlImages.Size = new System.Drawing.Size(582, 340);
            this.pnlImages.TabIndex = 4;
            // 
            // imageContextMenuStrip
            // 
            this.imageContextMenuStrip.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.imageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.openContainingFolderToolStripMenuItem});
            this.imageContextMenuStrip.Name = "imageContextMenuStrip";
            this.imageContextMenuStrip.Size = new System.Drawing.Size(212, 92);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openContainingFolderToolStripMenuItem
            // 
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.openContainingFolderToolStripMenuItem.Text = "Open containing folder...";
            this.openContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.openContainingFolderToolStripMenuItem_Click);
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.lvCopiedText);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(0, 57);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(582, 340);
            this.pnlText.TabIndex = 5;
            this.pnlText.Visible = false;
            // 
            // lvCopiedText
            // 
            this.lvCopiedText.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chText,
            this.chDate});
            this.lvCopiedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCopiedText.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lvCopiedText.FullRowSelect = true;
            this.lvCopiedText.Location = new System.Drawing.Point(0, 0);
            this.lvCopiedText.Name = "lvCopiedText";
            this.lvCopiedText.Size = new System.Drawing.Size(582, 340);
            this.lvCopiedText.TabIndex = 1;
            this.lvCopiedText.UseCompatibleStateImageBehavior = false;
            this.lvCopiedText.View = System.Windows.Forms.View.Details;
            this.lvCopiedText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvCopiedText_KeyDown);
            // 
            // chText
            // 
            this.chText.Text = "Copied Text";
            this.chText.Width = 440;
            // 
            // chDate
            // 
            this.chDate.Text = "Date of Copy";
            this.chDate.Width = 220;
            // 
            // UCHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlImages);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlDateFilter);
            this.Controls.Add(this.lvImageFiles);
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(704, 442);
            this.Load += new System.EventHandler(this.UCHistory_Load);
            this.VisibleChanged += new System.EventHandler(this.UCHistory_VisibleChanged);
            this.pnlDateFilter.ResumeLayout(false);
            this.pnlDateFilter.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.imageContextMenuStrip.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvImageFiles;
        private System.Windows.Forms.ColumnHeader chImageFile;
        private System.Windows.Forms.Panel pnlDateFilter;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ComboBox cbFilterDay;
        private System.Windows.Forms.ComboBox cbFilterMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterYear;
        private System.Windows.Forms.Panel pnlImages;
        private Bunifu.Framework.UI.BunifuFlatButton btnImageHistory;
        private Bunifu.Framework.UI.BunifuFlatButton btnTextHistory;
        private System.Windows.Forms.ContextMenuStrip imageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.ListView lvCopiedText;
        private System.Windows.Forms.ColumnHeader chText;
        private System.Windows.Forms.ColumnHeader chDate;
    }
}
