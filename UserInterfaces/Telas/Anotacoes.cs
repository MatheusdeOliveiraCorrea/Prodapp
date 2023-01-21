using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaces.Telas
{
    public partial class Anotacoes : Form
    {
        public Anotacoes()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("texto", "texto");

        }

        private void apertouCntrlS(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SalvarConteudo(textBox1.Text);
            }
        }

        private void SalvarConteudo(string texto)
        {
            dataGridView1.Rows.Add(texto);

            dataGridView1.Update();
        }
    }
}
