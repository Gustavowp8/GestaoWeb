using System.ComponentModel.DataAnnotations;

namespace GestaoWeb.Models
{
    public class Sala
    {
        [Key]
        public int IdSala { get; set; }

        public string Nome { get; set; }
    }
}
