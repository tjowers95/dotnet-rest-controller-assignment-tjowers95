using Microsoft.AspNetCore.Mvc;
using QuizAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Services
{
    public interface IQuizService
    {
        IEnumerable<Quiz> GetQuizzes();
        Quiz PostQuiz(Quiz quiz);
        Quiz DeleteQuiz(int quizId);
        Quiz PatchRenameQuiz(int quizId, string name);
        Quiz PatchAddQuestion(int quizId, Question question);
        Question DeleteQuestion(int quizId, int questionId);
    }
}
