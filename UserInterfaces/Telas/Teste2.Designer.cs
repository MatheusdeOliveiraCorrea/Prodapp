﻿namespace UserInterfaces.Telas
{
    partial class Teste2
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muitrasCoisasLoucaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coisasLoicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coisasSeriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coisasSeriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 154);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitrasCoisasLoucaToolStripMenuItem,
            this.coisasSeriasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muitrasCoisasLoucaToolStripMenuItem
            // 
            this.muitrasCoisasLoucaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coisasLoicasToolStripMenuItem});
            this.muitrasCoisasLoucaToolStripMenuItem.Name = "muitrasCoisasLoucaToolStripMenuItem";
            this.muitrasCoisasLoucaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.muitrasCoisasLoucaToolStripMenuItem.Text = "muitras coisas louca";
            // 
            // coisasLoicasToolStripMenuItem
            // 
            this.coisasLoicasToolStripMenuItem.Name = "coisasLoicasToolStripMenuItem";
            this.coisasLoicasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coisasLoicasToolStripMenuItem.Text = "coisas loicas";
            this.coisasLoicasToolStripMenuItem.Click += new System.EventHandler(this.coisasLoicasToolStripMenuItem_Click);
            // 
            // coisasSeriasToolStripMenuItem
            // 
            this.coisasSeriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coisasSeriasToolStripMenuItem1});
            this.coisasSeriasToolStripMenuItem.Name = "coisasSeriasToolStripMenuItem";
            this.coisasSeriasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.coisasSeriasToolStripMenuItem.Text = "coisas serias";
            // 
            // coisasSeriasToolStripMenuItem1
            // 
            this.coisasSeriasToolStripMenuItem1.Name = "coisasSeriasToolStripMenuItem1";
            this.coisasSeriasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.coisasSeriasToolStripMenuItem1.Text = "coisas serias";
            this.coisasSeriasToolStripMenuItem1.Click += new System.EventHandler(this.coisasSeriasToolStripMenuItem1_Click);
            // 
            // Teste2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teste2";
            this.Text = "Teste2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem muitrasCoisasLoucaToolStripMenuItem;
        private ToolStripMenuItem coisasLoicasToolStripMenuItem;
        private ToolStripMenuItem coisasSeriasToolStripMenuItem;
        private ToolStripMenuItem coisasSeriasToolStripMenuItem1;
    }
}