using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Models
{
    public class Anotacao
    {
        public string Titulo { get; set; } = string.Empty;

        public string Sobre { get; set; } = string.Empty;

        public DateTime Data { get; set; } = DateTime.MinValue;

        public string Texto { get; set; } = string.Empty;

    }
}
