using System.Drawing.Drawing2D;

namespace UserInterfaces.Telas
{
    public partial class Cronometro : Form
    {
        private DateTime inicio;
        private DateTime fim;
        private DateTime agora = DateTime.Now; 
        bool isLigado = false; 

        public Cronometro()
        {
            InitializeComponent();

            FormatarBotao();

            tempodecorrido.Visible = false;
        }

        private void FormatarBotao()
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(graphicsPath);
            button1.BackColor = Color.LightGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempodecorrido.Visible = true;

            if(isLigado is false)
            {
                isLigado = true; 
                inicio = DateTime.Now;

                iniciolabel.Text = $"{inicio.Hour:00}:{inicio.Minute:00}:{inicio.Second:00} - {inicio.Day:00}.{inicio.Month:00}.{inicio.Year:0000}";

                var mudarHoraTela = new Thread(MudarHoraNaTela);
                mudarHoraTela.Start();

                button1.BackColor = Color.IndianRed;

                button1.Image = Auxiliares.Imagens.imagens.iconePause;
                
                return; 
            }

            if (isLigado)
            {
                isLigado = false;
                fim = DateTime.Now;

                button1.BackColor = Color.LightGreen;
                button1.Image = Auxiliares.Imagens.imagens.iconePlay;

                FormatarBotao();
            }
        }

        private void MudarHoraNaTela()
        {
            try
            {
                while (isLigado)
                {
                    agora = DateTime.Now;

                    var tempoDe = agora - inicio; 

                    tempodecorrido.BeginInvoke(() => 
                    {
                        var texto = 
                        $"""
                          {tempoDe.Hours:00}  {tempoDe.Minutes:00}  {tempoDe.Seconds:00}  
                          h  min  seg
                         """;

                        tempodecorrido.Text = texto;
                        tempodecorrido.Update();
                    });

                    Thread.Sleep(500);
                }
            }
            catch (Exception)
            {
                //deu ruim
            }
        }
    }
}
