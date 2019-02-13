using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Data
{
    [Table("answer")]
    public class Answer
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("answer_text")]
        public string AnswerText { get; set; }

        [ForeignKey("Quiz")]
        public int QuizRefId { get; set; }

        [Column("is_correct")]
        public bool IsCorrect { get; set; }
    }
}
