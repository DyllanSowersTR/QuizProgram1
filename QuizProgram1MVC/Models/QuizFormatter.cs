using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class QuizFormatter : IQuizFormatter
    {
        private IQuizFormatter quizFormatter;

        public QuizFormatter(IQuizFormatter quizFormatter)
        {
            this.quizFormatter = quizFormatter;
        }

        public string Format(IQuestion question)
        {
            return quizFormatter.Format(question);
        }
    }
}