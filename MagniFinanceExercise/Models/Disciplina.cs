using System.ComponentModel.DataAnnotations;

namespace MagniFinanceExercise.Models
{
    public class Disciplina
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Escreva um nome")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
