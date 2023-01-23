using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdAppCore.Classes.Cronometro
{
    public class Cronometro
    {
        public bool IsLigado { get; set; }

        public DateTime Inicio { get; set; }

        public TimeSpan TempoDecorrido { get; set; }

        public void Ligar()
        {
            if (IsLigado)
                throw new Exception("Já está ligado");

            IsLigado = true;
            Inicio = DateTime.Now;
            ContarTempo();
        }

        public void Desligar()
        {
            if (IsLigado is false)
                throw new Exception("Já está desligado");

            IsLigado = false; 
        }

        private void ContarTempo()
        {
            while (IsLigado)
            {
                TempoDecorrido = DateTime.Now.Subtract(Inicio);
                Thread.Sleep(500);
            }
        }

    }
}
