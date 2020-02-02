using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class QuizFormatForWeb : IQuizFormatter
    {
        public string Format(IQuestion question)
        {
            string message = "";

            message += "<b>" + question.Question + "</b><br/>";

            foreach (object answer in question.GetAnswers())
            {
                message += answer + "<br/>";
            }

            message += "<br/>";

            return message;
        }
    }
}