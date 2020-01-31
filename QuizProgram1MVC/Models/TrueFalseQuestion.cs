using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class TrueFalseQuestion : IQuestion
    {
        public string question { get; set; }
        private List<object> correctAnswers = new List<object>();

        public TrueFalseQuestion()
        {
            //
        }

        public List<object> getAnswers()
        {
            return [true, false];
        }

        public List<object> getCorrectAnswers()
        {
            return correctAnswers;
        }

        public void addAnswer(object answer)
        {
            //
        }

        public void removeAnswer(object answer)
        {
            //
        }

        public void addCorrectAnswer(object answer)
        {
            correctAnswers[0] = answer;
        }

        public void removeCorrectAnswer(object answer)
        {
            correctAnswers[0] = default;
        }
    }
}