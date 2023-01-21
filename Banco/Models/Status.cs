using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Models
{
    public class Status
    {
        public const int Incompleto = (int)Situacao.Incompleto;

        public const int Completo = (int)Situacao.Concluido;

        private enum Situacao
        {
            Incompleto = 0,
            Concluido = 1
        }
    }
}
