using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class Quiz
    {
        public List<IQuestion> questions = new List<IQuestion>();

        public Quiz()
        {
            //
        }

        public void AddQuestion(IQuestion question)
        {
            questions.Add(question);
        }

        public void RemoveQuestion(IQuestion question)
        {
            questions.Remove(question);
        }
    }
}