namespace LearningWinform2
{
    partial class BaseForm
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fOntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnView = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewSortAI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewSortC = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIleVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.mnView});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 30);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // mnFile
            // 
            this.mnFile.AutoSize = false;
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFileNew,
            this.mnFileOpen,
            this.toolStripSeparator1,
            this.mnFileSave,
            this.toolStripSeparator2,
            this.mnFilePrint,
            this.toolStripMenuItem1,
            this.mnFileExit});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(152, 26);
            this.mnFile.Text = "&File";
            // 
            // mnFileNew
            // 
            this.mnFileNew.Image = global::LearningWinform2.Properties.Resources.naruto;
            this.mnFileNew.Name = "mnFileNew";
            this.mnFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnFileNew.Size = new System.Drawing.Size(224, 26);
            this.mnFileNew.Text = "New";
            this.mnFileNew.Click += new System.EventHandler(this.mnFileNew_Click);
            // 
            // mnFileOpen
            // 
            this.mnFileOpen.Name = "mnFileOpen";
            this.mnFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnFileOpen.Size = new System.Drawing.Size(224, 26);
            this.mnFileOpen.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnFileSave
            // 
            this.mnFileSave.Name = "mnFileSave";
            this.mnFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnFileSave.Size = new System.Drawing.Size(224, 26);
            this.mnFileSave.Text = "Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnFilePrint
            // 
            this.mnFilePrint.Name = "mnFilePrint";
            this.mnFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnFilePrint.Size = new System.Drawing.Size(224, 26);
            this.mnFilePrint.Text = "Print";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnFileExit
            // 
            this.mnFileExit.Name = "mnFileExit";
            this.mnFileExit.Size = new System.Drawing.Size(224, 26);
            this.mnFileExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToFileToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.goToToolStripMenuItem.Text = "&Go to";
            // 
            // goToFileToolStripMenuItem
            // 
            this.goToFileToolStripMenuItem.Name = "goToFileToolStripMenuItem";
            this.goToFileToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.goToFileToolStripMenuItem.Text = "Go to File";
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickFindToolStripMenuItem,
            this.quickReplaceToolStripMenuItem});
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.findAndReplaceToolStripMenuItem.Text = "&Find and Replace";
            // 
            // quickFindToolStripMenuItem
            // 
            this.quickFindToolStripMenuItem.Name = "quickFindToolStripMenuItem";
            this.quickFindToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.quickFindToolStripMenuItem.Text = "Quick Find";
            // 
            // quickReplaceToolStripMenuItem
            // 
            this.quickReplaceToolStripMenuItem.Name = "quickReplaceToolStripMenuItem";
            this.quickReplaceToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.quickReplaceToolStripMenuItem.Text = "Quick Replace";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fOntToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fOntToolStripMenuItem
            // 
            this.fOntToolStripMenuItem.Name = "fOntToolStripMenuItem";
            this.fOntToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.fOntToolStripMenuItem.Text = "Font";
            // 
            // mnView
            // 
            this.mnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitToolStripMenuItem1,
            this.mnViewSort});
            this.mnView.Name = "mnView";
            this.mnView.Size = new System.Drawing.Size(55, 26);
            this.mnView.Text = "View";
            // 
            // splitToolStripMenuItem1
            // 
            this.splitToolStripMenuItem1.Name = "splitToolStripMenuItem1";
            this.splitToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.splitToolStripMenuItem1.Text = "Split";
            // 
            // mnViewSort
            // 
            this.mnViewSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnViewSortAI,
            this.mnViewSortC,
            this.tileHorizonToolStripMenuItem,
            this.tIleVerticalToolStripMenuItem});
            this.mnViewSort.Name = "mnViewSort";
            this.mnViewSort.Size = new System.Drawing.Size(224, 26);
            this.mnViewSort.Text = "&Sort";
            // 
            // mnViewSortAI
            // 
            this.mnViewSortAI.Name = "mnViewSortAI";
            this.mnViewSortAI.Size = new System.Drawing.Size(224, 26);
            this.mnViewSortAI.Text = "Arrange Icons";
            this.mnViewSortAI.Click += new System.EventHandler(this.mnViewSortAI_Click);
            // 
            // mnViewSortC
            // 
            this.mnViewSortC.Name = "mnViewSortC";
            this.mnViewSortC.Size = new System.Drawing.Size(224, 26);
            this.mnViewSortC.Text = "Cascade";
            this.mnViewSortC.Click += new System.EventHandler(this.mnViewSortC_Click);
            // 
            // tileHorizonToolStripMenuItem
            // 
            this.tileHorizonToolStripMenuItem.Name = "tileHorizonToolStripMenuItem";
            this.tileHorizonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tileHorizonToolStripMenuItem.Text = "Tile Horizon";
            this.tileHorizonToolStripMenuItem.Click += new System.EventHandler(this.tileHorizonToolStripMenuItem_Click);
            // 
            // tIleVerticalToolStripMenuItem
            // 
            this.tIleVerticalToolStripMenuItem.Name = "tIleVerticalToolStripMenuItem";
            this.tIleVerticalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tIleVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tIleVerticalToolStripMenuItem.Click += new System.EventHandler(this.tIleVerticalToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.Name = "BaseForm";
            this.Text = "Base form";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnFileExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fOntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnView;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnViewSort;
        private System.Windows.Forms.ToolStripMenuItem mnViewSortAI;
        private System.Windows.Forms.ToolStripMenuItem mnViewSortC;
        private System.Windows.Forms.ToolStripMenuItem tileHorizonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIleVerticalToolStripMenuItem;
    }
}

