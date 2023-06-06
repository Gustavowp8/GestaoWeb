using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoWeb.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Display(Name = "Nome do Cliente: ")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Não pode ser maior que 50 e menor que 6")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Display(Name = "Nome do ponto: ")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Não pode ser maior que 50 e menor que 6")]
        public string NomePonto { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Display(Name = "Nome da cidade: ")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Não pode ser maior que 50 e menor que 6")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Display(Name = "Nome do Estado: ")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Não pode ser maior que 2 e menor que 1")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Display(Name = "Logradouro: ")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Não pode ser maior que 50 e menor que 6")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Display(Name = "Selecione a imagem: ")]
        [StringLength(200, MinimumLength = 6, ErrorMessage = "Não pode ser maior que 50 e menor que 6")]
        public string ImagemUrl { get; set; }

        //Tebela relacionada
        [ForeignKey("Sala")]
       public int IdSala { get; set; }
        public Sala Sala { get; set; }



    }
}
