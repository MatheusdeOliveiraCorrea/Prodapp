using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                if(!string.IsNullOrEmpty(ObterTitulo()) && !string.IsNullOrEmpty(ObterSobre()))
                SalvarConteudo(textBox1.Text);
            }
        }

        private string ObterTitulo()
        {
            var texto = textBox1.Text;

            if (string.IsNullOrEmpty(texto))
                throw new Exception("Texto Vazio");

            var matchCollection = new Regex(@"\S+").Matches(texto);

            var palavras = new List<string>();
            matchCollection.ToList().ForEach(x => palavras.Add(x.Value));

            var titulo = new StringBuilder(); 
            foreach (var palavra in palavras)
            {
                if (palavra.Equals("Titulo:"))
                    continue;

                if (palavra.Equals("Sobre:"))
                    break;

                titulo.Append(palavra + " ");
            }

            return titulo.ToString(); 
        }

        private string ObterSobre() 
        {
            return "";
        }

        private void SalvarConteudo(string texto)
        {
            dataGridView1.Rows.Add(texto);

            dataGridView1.Update();
        }
    }
}
