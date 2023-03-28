using System.ComponentModel.DataAnnotations;
using Banco.Models;
using Banco.Models;

namespace ProdAppCore.Classes
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        [Required]
        [StringLength(80)]
        public string Titulo { get; set; }

        [Required]
        public string Conteudo { get; set; }

        [Required]
        public Situacao Status { get; set; }
        
        public Tarefa() 
        {
            
        }
    }
}
