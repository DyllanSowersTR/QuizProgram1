using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class MultipleChoiceQuestion : IQuestion
    {
        public string Question { get; set; }
        private readonly List<object> answers = new List<object>();
        private readonly List<object> correctAnswers = new List<object>();

        public MultipleChoiceQuestion()
        {
            //
        }

        public List<object> GetAnswers()
        {
            return answers;
        }

        public List<object> GetCorrectAnswers()
        {
            return correctAnswers;
        }

        public void AddAnswer(object answer)
        {
            answers.Add(answer);
        }

        public void RemoveAnswer(object answer)
        {
            answers.Remove(answer);
        }

        public void AddCorrectAnswer(object answer)
        {
            correctAnswers.Add(answer);
        }

        public void RemoveCorrectAnswer(object answer)
        {
            correctAnswers.Remove(answer);
        }
    }
}