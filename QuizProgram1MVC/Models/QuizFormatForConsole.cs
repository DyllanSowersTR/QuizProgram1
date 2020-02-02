using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class QuizFormatForConsole : IQuizFormatter
    {
        public string Format(IQuestion question)
        {
            string message = "";

            message += question.Question + "\n";

            foreach (object answer in question.GetAnswers())
            {
                message += answer + "\n";
            }

            message += "\n";

            return message;
        }
    }
}