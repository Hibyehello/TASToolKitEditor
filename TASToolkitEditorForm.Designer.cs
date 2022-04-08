﻿namespace TASToolKitEditor
{
    partial class TASToolKitEditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.inputCenteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centered0Button = new System.Windows.Forms.ToolStripMenuItem();
            this.centered7Button = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGridView
            // 
            this.inputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputGridView.Location = new System.Drawing.Point(12, 50);
            this.inputGridView.Name = "inputGridView";
            this.inputGridView.RowTemplate.Height = 25;
            this.inputGridView.Size = new System.Drawing.Size(265, 389);
            this.inputGridView.TabIndex = 0;
            this.inputGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onInputChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(289, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpen,
            this.inputCenteringToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(157, 22);
            this.fileOpen.Text = "Open";
            this.fileOpen.Click += new System.EventHandler(this.onClickFileOpen);
            // 
            // inputCenteringToolStripMenuItem
            // 
            this.inputCenteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centered0Button,
            this.centered7Button});
            this.inputCenteringToolStripMenuItem.Name = "inputCenteringToolStripMenuItem";
            this.inputCenteringToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.inputCenteringToolStripMenuItem.Text = "Input Centering";
            // 
            // centered0Button
            // 
            this.centered0Button.Name = "centered0Button";
            this.centered0Button.Size = new System.Drawing.Size(131, 22);
            this.centered0Button.Text = "0 Centered";
            this.centered0Button.Click += new System.EventHandler(this.on0CenterClick);
            // 
            // centered7Button
            // 
            this.centered7Button.Name = "centered7Button";
            this.centered7Button.Size = new System.Drawing.Size(131, 22);
            this.centered7Button.Text = "7 Centered";
            this.centered7Button.Click += new System.EventHandler(this.on7CenterClick);
            // 
            // TASToolKitEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 451);
            this.Controls.Add(this.inputGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "TASToolKitEditorForm";
            this.Text = "TTK Input Editor";
            this.Activated += new System.EventHandler(this.onGainFocus);
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inputGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem inputCenteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centered0Button;
        private System.Windows.Forms.ToolStripMenuItem centered7Button;
    }
}
