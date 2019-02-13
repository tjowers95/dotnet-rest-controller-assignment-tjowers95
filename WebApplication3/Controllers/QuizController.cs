using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizAPI.Data;
using QuizAPI.Services;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet("/")]
        public ContentResult Landing()
        {
            return Content("<html style=\"background-color:black;\"><h1 style=\"color:purple;\">Welcome To Quizademia</h1></html>", "text/html");
        }

        // GET return all quizzes
        [HttpGet("/quiz")]
        public ActionResult<IEnumerable<Quiz>> Get()
        {
            var quizzes = _quizService.GetQuizzes();

            if (quizzes == null)
                return NotFound();

            return Ok(quizzes);
        }

        // POST create a new quiz, return created quiz
        [HttpPost("/quiz")]
        public ActionResult<Quiz> Post([FromBody] Quiz quiz)
        {
            if (quiz == null)
                return NotFound();

            return Ok(_quizService.PostQuiz(quiz));
        }

        // DELETE remove quiz by id, return deleted quiz
        [HttpDelete("/quiz/{quizId}")]
        public ActionResult<Quiz> Delete(int quizId)
        {
            var quiz = _quizService.DeleteQuiz(quizId);

            if (quiz == null)
                return NotFound();

            return Ok(quiz);
        }

        // PATCH rename quiz, return renamed quiz
        [HttpPatch("/quiz/{quizId}/rename/{name}")]
        public ActionResult<Quiz> Patch(int quizId, string name)
        {
            var quiz = _quizService.PatchRenameQuiz(quizId, name);

            if (quiz == null)
                return NotFound();

            return Ok(quiz);
        }

        // PATCH add question to quiz, return quiz
        [HttpPatch("/quiz/{quizId}/add")]
        public ActionResult<Quiz> Patch(int quizId, [FromBody] Question question)
        {
            var result = _quizService.PatchAddQuestion(quizId, question);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // DELETE remove question from quiz
        [HttpDelete("/quiz/{quizId}/{questionId}")]
        public ActionResult<Question> Delete(int quizId, int questionId)
        {
            var result = _quizService.DeleteQuestion(quizId, questionId);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
