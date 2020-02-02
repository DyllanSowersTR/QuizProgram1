using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizProgram1MVC.Models;

namespace QuizProgram1MVC.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            Quiz quiz = new Quiz(new QuizFormatForWeb());

            IQuestion question1 = new QuizQuestion(new TrueFalseQuestion());
            question1.Question = "Is blue a color?";
            question1.AddCorrectAnswer(true);
            quiz.AddQuestion(question1);

            IQuestion question2 = new QuizQuestion(new MultipleChoiceQuestion());
            question2.Question = "How many states are there in the United States of America?";
            question2.AddAnswer(25);
            question2.AddAnswer(75);
            question2.AddAnswer(50);
            question2.AddCorrectAnswer(50);
            quiz.AddQuestion(question2);

            ViewBag.Quiz = quiz;

            return View();
        }
    }
}