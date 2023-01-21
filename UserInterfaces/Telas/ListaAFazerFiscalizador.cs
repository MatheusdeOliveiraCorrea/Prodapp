using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterfaces.Telas
{
    public partial class ListaAFazerFiscalizador : Form
    {
        public ListaAFazerFiscalizador()
        {
            InitializeComponent();
        }

        private void ListaAFazerFiscalizador_Load(object sender, EventArgs e)
        {
            FormatandoTreeView();
            PreencherFicticios();
        }

        private void PreencherFicticios() 
        {
            for (int i = 1; i <= 15; i++)
            {
                var textChave = $"curso{i}";
                var nodePai = new TreeNode { Name = textChave, Text = textChave };

                AddElementoPai(nodePai);
            }

            for (int i = 1; i <= 5; i++)
            {
                var textChave = $"aula{i}";

                var nodeFilho = new TreeNode { Name = textChave, Text = textChave };

                foreach (TreeNode pai in treeView1.Nodes)
                {
                    AddElementoFilho(pai.Name, nodeFilho);
                }
            }

            foreach (var nodePai in treeView1.Nodes)
            {

            }
        }

        private void FormatandoTreeView()
        {
            treeView1.AfterCheck += (o, e) =>
            {
                if (e.Node is null)
                    return; 

                if(e.Node.Checked)
                {
                    e.Node.ForeColor = Color.Green;
                    return;
                }

                e.Node.ForeColor = Color.Black; 
            };
        }

        private void AddElementoPai(TreeNode nodePai)
        {
            treeView1.Nodes.Add(nodePai);
        }

        private void AddElementoFilho(string keyNodePai, TreeNode nodeFilho)
        {
            if (string.IsNullOrEmpty(keyNodePai) || string.IsNullOrEmpty(nodeFilho.Name))
                return;

            if (!treeView1.Nodes.ContainsKey(keyNodePai))
                return;

            var nodeRepetido = treeView1.Nodes.Find(nodeFilho.Name, true).Length > 0;

            if (!nodeRepetido)
                treeView1.Nodes[keyNodePai].Nodes.Add(nodeFilho);

            if (nodeRepetido)
                treeView1.Nodes[keyNodePai].Nodes.Add((TreeNode)nodeFilho.Clone());
        }
    }
}
