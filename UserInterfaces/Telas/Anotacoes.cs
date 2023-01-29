using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Banco.Models;

namespace UserInterfaces.Telas
{
    public partial class Anotacoes : Form
    {
        public Anotacoes()
        {
            InitializeComponent();

            FormatarTexto();
        }

        private void TirarColunas()
        {
            dataGridView1.Columns[nameof(Anotacao.Sobre)].Visible = false;
            dataGridView1.Columns[nameof(Anotacao.Data)].Visible = false;
            dataGridView1.Columns[nameof(Anotacao.Texto)].Visible = false;
        }

        private void FormatarTexto()
        {
            header.Text = EscreverNaFrente(header.Text, "Data:", $" {DateTime.Now:dd/MM/yyyy}");
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

        }

        private string ObterTitulo()
        {
            var texto = header.Text;

            if (string.IsNullOrEmpty(texto))
                throw new Exception("Texto Vazio");

            var matchCollection = ObterPalavras(texto);

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
            var texto = body.Text;

            if (string.IsNullOrEmpty(texto))
                throw new Exception("Texto Vazio");

            var matchCollection = SelecionarPalavras().Matches(texto);

            var palavras = new List<string>();
            matchCollection.ToList().ForEach(x => palavras.Add(x.Value));

            var sobre = new StringBuilder();
            foreach (var palavra in palavras)
            {
                if (palavra.Equals("Titulo:"))
                    continue;

                if (palavra.Equals("Sobre:"))
                    continue;

                if (palavra.Equals("Data:"))
                    break;

                sobre.Append(palavra + " ");
            }

            return sobre.ToString();
        }

        private void SalvarConteudo(string texto)
        {
            var anotacoes = new List<Anotacao>
            {
                new Anotacao { Titulo = ObterTitulo(), Texto = ObterPalavras(body.Text).ToString() }
            };

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = anotacoes;

            TirarColunas();

            dataGridView1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ObterTitulo()))
                SalvarConteudo(body.Text);
        }

        private void keydownevent(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                if (!string.IsNullOrEmpty(ObterTitulo()) && !string.IsNullOrEmpty(ObterSobre()))
                    SalvarConteudo(body.Text);
            }
        }

        [GeneratedRegex("\\S+")]
        private static partial Regex SelecionarPalavras();

        private static MatchCollection ObterPalavras(string texto) => SelecionarPalavras().Matches(texto);
    }
}
