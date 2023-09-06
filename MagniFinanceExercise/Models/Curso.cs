﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MagniFinanceExercise.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

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

        [Required(ErrorMessage = "Escolha uma disciplina")]
        [ForeignKey("Disciplina")]
        [Display(Name = "Disciplina")]
        public int DisciplinaId { get; set; }

        public Disciplina disciplina { get; set; }
    }
}
