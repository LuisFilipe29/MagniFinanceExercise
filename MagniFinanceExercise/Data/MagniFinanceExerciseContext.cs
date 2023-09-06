using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MagniFinanceExercise.Models;

namespace MagniFinanceExercise.Data
{
    public class MagniFinanceExerciseContext : DbContext
    {
        public MagniFinanceExerciseContext (DbContextOptions<MagniFinanceExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<MagniFinanceExercise.Models.Aluno> Aluno { get; set; }

        public DbSet<MagniFinanceExercise.Models.Curso> Curso { get; set; }

        public DbSet<MagniFinanceExercise.Models.Disciplina> Disciplina { get; set; }

        public DbSet<MagniFinanceExercise.Models.Prof> Prof { get; set; }
    }
}
