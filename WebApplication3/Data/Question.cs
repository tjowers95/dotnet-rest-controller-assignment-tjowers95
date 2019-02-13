using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Data
{
    [Table("questions")]
    public class Question
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("question_text")]
        public string QuestionText { get; set; }

    }
}
