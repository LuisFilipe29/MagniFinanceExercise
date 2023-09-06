using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagniFinanceExercise.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Escolha um aluno")]
        [ForeignKey("Aluno")]
        [Display(Name = "Aluno")]
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        [Required(ErrorMessage = "Escolha um curso")]
        [ForeignKey("Curso")]
        [Display(Name = "Curso")]
        public int CursoId { get; set; }

        public Curso curso { get; set; }

        [Required(ErrorMessage = "Insira o valor")]
        [Display(Name = "Valor")]
        public int Valor { get; set; }
    }
}
