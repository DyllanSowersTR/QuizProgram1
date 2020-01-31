using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class MultipleChoiceQuestion : IQuestion
    {
        public string question { get; set; }
        private List<object> answers = new List<object>();
        private List<object> correctAnswers = new List<object>();

        public MultipleChoiceQuestion()
        {
            //
        }

        public List<object> getAnswers()
        {
            return answers;
        }

        public List<object> getCorrectAnswers()
        {
            return correctAnswers;
        }

        public void addAnswer(object answer)
        {
            answers.Add(answer);
        }

        public void removeAnswer(object answer)
        {
            answers.Remove(answer);
        }

        public void addCorrectAnswer(object answer)
        {
            correctAnswers.Add(answer);
        }

        public void removeCorrectAnswer(object answer)
        {
            correctAnswers.Remove(answer);
        }
    }
}