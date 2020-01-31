using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class TrueFalseQuestion : IQuestion
    {
        public string Question { get; set; }
        private readonly List<object> correctAnswers = new List<object>();

        public TrueFalseQuestion()
        {
            //
        }

        public List<object> GetAnswers()
        {
            return new List<object> { true, false };
        }

        public List<object> GetCorrectAnswers()
        {
            return correctAnswers;
        }

        public void AddAnswer(object answer)
        {
            //
        }

        public void RemoveAnswer(object answer)
        {
            //
        }

        public void AddCorrectAnswer(object answer)
        {
            correctAnswers[0] = answer;
        }

        public void RemoveCorrectAnswer(object answer)
        {
            correctAnswers[0] = default;
        }
    }
}