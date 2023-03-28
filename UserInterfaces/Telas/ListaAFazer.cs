using Banco.Models;
using ProdAppCore.Classes;
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
    public partial class ListaAFazer : Form
    {
        public ListaAFazer()
        {
            InitializeComponent();
        }

        private void ListaAFazer_Load(object sender, EventArgs e)
        {
            List<Tarefa> listaFazer = new List<Tarefa>
            {
                new Tarefa {Titulo = "titulo qualquer", Status = Situacao.Concluido},
                new Tarefa {Titulo = "outro titulo", Status = Situacao.Incompleto}
            };

            gridFazer.DataSource = listaFazer;
            EsconderColunas();

            FormatarGrid();

            CriarMenuGrid();
        }

        private void FormatarGrid()
        {
            var novaColunaSituacao = new DataGridViewColumn
            {
                HeaderText = "Situacao",
                Name = "Situacao",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            gridFazer.Columns.Add(novaColunaSituacao);

            var indexColunaSituacao = gridFazer.Columns[novaColunaSituacao.Name].Index;

            gridFazer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < gridFazer.Rows.Count; i++)
            {
                var celulastatus = (int)gridFazer[nameof(Tarefa.Status), i].Value;

                gridFazer[indexColunaSituacao, i].Value = Status.ObterDescricao(celulastatus);
            }
        }

        private void EsconderColunas()
        {
            try
            {
                gridFazer.Columns[nameof(Tarefa.TarefaId)].Visible = false;
                gridFazer.Columns[nameof(Tarefa.Status)].Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void CriarMenuGrid()
        {
            var adicionar = new ToolStripMenuItem 
            {
                Text = "Adicionar"
            };

            var remover = new ToolStripMenuItem
            {
                Text = "Remover"
            };

            var itens = new ToolStripMenuItem[]
            {
                adicionar,
                remover
            };

            adicionar.Click += new EventHandler(adicionar_Click);

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.AddRange(itens); 

            gridFazer.ContextMenuStrip = menu; 
        }

        private void adicionar_Click(object? sender, EventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();

            //gridFazer.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
