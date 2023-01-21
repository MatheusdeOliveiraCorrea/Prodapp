namespace UserInterfaces.Telas
{
    partial class Cronometro
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
            this.label3 = new System.Windows.Forms.Label();
            this.tempodecorrido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iniciolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::UserInterfaces.Auxiliares.Imagens.imagens.iconePlay;
            this.button1.Location = new System.Drawing.Point(122, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 86);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tempo decorrido:";
            // 
            // tempodecorrido
            // 
            this.tempodecorrido.AutoSize = true;
            this.tempodecorrido.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tempodecorrido.ForeColor = System.Drawing.Color.OrangeRed;
            this.tempodecorrido.Location = new System.Drawing.Point(39, 139);
            this.tempodecorrido.Name = "tempodecorrido";
            this.tempodecorrido.Size = new System.Drawing.Size(340, 54);
            this.tempodecorrido.TabIndex = 5;
            this.tempodecorrido.Text = "tempo decorrido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Começou às:";
            // 
            // iniciolabel
            // 
            this.iniciolabel.AutoSize = true;
            this.iniciolabel.ForeColor = System.Drawing.Color.White;
            this.iniciolabel.Location = new System.Drawing.Point(91, 9);
            this.iniciolabel.Name = "iniciolabel";
            this.iniciolabel.Size = new System.Drawing.Size(36, 15);
            this.iniciolabel.TabIndex = 7;
            this.iniciolabel.Text = "inicio";
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(329, 378);
            this.Controls.Add(this.iniciolabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempodecorrido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "Cronometro";
            this.Text = "Cronometro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label tempodecorrido;
        private Label label4;
        private Label iniciolabel;
    }
}