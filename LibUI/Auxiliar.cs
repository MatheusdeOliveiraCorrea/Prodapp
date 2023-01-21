namespace LibUI
{
    public class Auxiliar
    {
        public static void AddNoPainel(Panel painel, Form tela, Form pai, bool show = true)
        {
            painel.Controls.Clear();

            tela.MdiParent = pai;
            tela.FormBorderStyle = FormBorderStyle.None; 

            painel.Controls.Add(tela);

            if(show is true)
                tela.Show();
        }
    }
}
