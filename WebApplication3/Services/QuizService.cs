using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAPI.Services
{
    public class QuizService : IQuizService
    {
        private QuizContext _quizContext;

        public QuizService(QuizContext context)
        {
            this._quizContext = context;
        }

        public IEnumerable<Quiz> GetQuizzes()
        {
            return _quizContext.Quizzes.ToList();
        }

        public Quiz PostQuiz(Quiz quiz)
        {
            _quizContext.Add(quiz);
            _quizContext.SaveChanges();
            return quiz;
        }
        public Quiz DeleteQuiz(int quizId)
        {
            Quiz quiz = _quizContext
                        .Quizzes
                        .Include(x => x.Questions)
                        .First(q => q.Id == quizId);

            var questions = quiz.Questions;

            foreach (var q in questions)
                _quizContext.Remove(q);
               
            _quizContext.Remove(quiz);
            _quizContext.SaveChanges();

            return quiz;
        }

        public Quiz PatchRenameQuiz(int id, string newName)
        {
            Quiz quiz = _quizContext
                        .Quizzes
                        .First(q => q.Id == id);

            quiz.Title = newName;
            _quizContext.Update(quiz);
            _quizContext.SaveChanges();

            return quiz;
        }

        public Quiz PatchAddQuestion(int quizId, Question question)
        {
            Quiz quiz = _quizContext
                        .Quizzes.Include(q => q.Questions)
                        .First(q => q.Id == quizId);

            quiz.Questions.Add(question);
            _quizContext.Update(quiz);
            _quizContext.SaveChanges();

            return quiz;
        }

        public Question DeleteQuestion(int quizId, int questionId)
        {
            Question question = _quizContext
                                .Quizzes
                                .Include(q => q.Questions)
                                .First(q => q.Id == quizId)
                                .Questions
                                .First(q => q.Id == questionId);
            _quizContext.Remove(question);
            _quizContext.SaveChanges();

            return question;
        }
    }
}
