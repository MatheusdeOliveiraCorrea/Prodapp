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
                new Tarefa {Titulo = "titulo qualquer", Status = 2},
                new Tarefa {Titulo = "outro titulo", Status = 3}
            };

            CriarMenuGrid(); 

            gridFazer.DataSource = listaFazer;
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
