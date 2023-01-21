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

            FormatarTexto();

        }

        private void FormatarTexto()
        {
            textBox1.Text = EscreverNaFrente(textBox1.Text, "Data:", " " + DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private string EscreverNaFrente(string textoCompleto, string palavra, object valor)
        {
            var stringBuilder = new StringBuilder(textoCompleto);

            var indicePalavra = textoCompleto.IndexOf(palavra) + palavra.Length;

            stringBuilder.Insert(indicePalavra, " " + valor);

            return stringBuilder.ToString();
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
