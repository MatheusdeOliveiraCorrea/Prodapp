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

        public static string ObterDescricao(int status)
        {
            switch (status)
            {
                case Incompleto:
                    return nameof(Incompleto);
                    break;

                case Completo:
                    return nameof(Completo);
                    break;

                default:
                    return string.Empty;
            }
        }
    }

    public enum Situacao
    {
        Incompleto = 0,
        Concluido = 1
    }
}
