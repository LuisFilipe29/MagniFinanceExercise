using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MagniFinanceExercise.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Escreva um nome")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Escolha um professor")]
        [ForeignKey("Professor")]
        [Display(Name = "Professor")]
        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }


        [Required(ErrorMessage = "Escolha um aluno")]
        [ForeignKey("Aluno")]
        [Display(Name = "Aluno")]
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        [Required]
        [ForeignKey("Nota")]
        [Display(Name = "Nota")]
        public int NotaId { get; set; }

        public Nota Nota { get; set; }
    }
}
