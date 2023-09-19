namespace LearningWinform2
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doiMauXanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMauDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.toolStripMenuItem1});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // New
            // 
            this.New.Image = global::LearningWinform2.Properties.Resources.naruto;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(224, 26);
            this.New.Text = "New";
            // 
            // Open
            // 
            this.Open.Image = global::LearningWinform2.Properties.Resources.sasuke;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(224, 26);
            this.Open.Text = "Open";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(49, 24);
            this.Edit.Text = "Edit";
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(172, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMauXanhToolStripMenuItem,
            this.doiMauDoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 52);
            // 
            // doiMauXanhToolStripMenuItem
            // 
            this.doiMauXanhToolStripMenuItem.Name = "doiMauXanhToolStripMenuItem";
            this.doiMauXanhToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.doiMauXanhToolStripMenuItem.Text = "Doi mau xanh";
            this.doiMauXanhToolStripMenuItem.Click += new System.EventHandler(this.doiMauXanhToolStripMenuItem_Click);
            // 
            // doiMauDoToolStripMenuItem
            // 
            this.doiMauDoToolStripMenuItem.Name = "doiMauDoToolStripMenuItem";
            this.doiMauDoToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.doiMauDoToolStripMenuItem.Text = "Doi mau do";
            this.doiMauDoToolStripMenuItem.Click += new System.EventHandler(this.doiMauDoToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(446, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doiMauXanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMauDoToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}