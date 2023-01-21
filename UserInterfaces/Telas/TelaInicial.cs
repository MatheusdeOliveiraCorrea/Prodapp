using LibUI; 

namespace UserInterfaces.Telas
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auxiliar.AddNoPainel(panel1, new ListaAFazer(), this); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auxiliar.AddNoPainel(panel1, new Anotacoes(), this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            new Cronometro().Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Auxiliar.AddNoPainel(panel1, new ListaAFazerFiscalizador(), this);
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
        }
    }
}
