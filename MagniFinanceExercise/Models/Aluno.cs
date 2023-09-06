using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagniFinanceExercise.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Escreva um nome")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Escreva a sua data de nascimento")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> Birthdate { get; set; }

        [Required(ErrorMessage = "Insira o número da matricula")]
        [Display(Name = "Número Matricula")]
        public int Num_Matricula { get; set; }

        [Required(ErrorMessage = "Escolha uma disciplina")]
        [ForeignKey("Disciplina")]
        [Display(Name = "Disciplina")]
        public int DisciplinaId { get; set; }

        public Disciplina disciplina { get; set; }
    }
}
