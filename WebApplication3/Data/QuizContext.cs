using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuizAPI.Data
{
    public class QuizContext : DbContext
    {
        public DbSet<Quiz> Quizzes { get; set; }
        
        public DbSet<Question> Questions { get; set; }

        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        { }
    }

}
