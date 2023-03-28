namespace UserInterfaces.Telas
{
    partial class ListaAFazer
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridFazer = new System.Windows.Forms.DataGridView();
            this.tabConcluidos = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFazer)).BeginInit();
            this.tabConcluidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabConcluidos);
            this.tabControl.Location = new System.Drawing.Point(0, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(599, 462);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridFazer);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fazer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridFazer
            // 
            this.gridFazer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFazer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridFazer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFazer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFazer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFazer.Location = new System.Drawing.Point(3, 3);
            this.gridFazer.Name = "gridFazer";
            this.gridFazer.RowTemplate.Height = 25;
            this.gridFazer.Size = new System.Drawing.Size(585, 428);
            this.gridFazer.TabIndex = 0;
            // 
            // tabConcluidos
            // 
            this.tabConcluidos.Controls.Add(this.dataGridView2);
            this.tabConcluidos.Location = new System.Drawing.Point(4, 24);
            this.tabConcluidos.Name = "tabConcluidos";
            this.tabConcluidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConcluidos.Size = new System.Drawing.Size(591, 434);
            this.tabConcluidos.TabIndex = 1;
            this.tabConcluidos.Text = "Concluidos";
            this.tabConcluidos.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(585, 428);
            this.dataGridView2.TabIndex = 1;
            // 
            // ListaAFazer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 458);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaAFazer";
            this.Text = "ListaAFazer";
            this.Load += new System.EventHandler(this.ListaAFazer_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFazer)).EndInit();
            this.tabConcluidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private DataGridView gridFazer;
        private TabPage tabConcluidos;
        private DataGridView dataGridView2;
    }
}