using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class QuizQuestion : IQuestion
    {
        private IQuestion questionType;
        public string Question { get; set; }

        public QuizQuestion(IQuestion question)
        {
            this.questionType = question;
        }

        public void AddAnswer(object answer)
        {
            questionType.AddAnswer(answer);
        }

        public void AddCorrectAnswer(object answer)
        {
            questionType.AddCorrectAnswer(answer);
        }

        public List<object> GetAnswers()
        {
            return questionType.GetAnswers();
        }

        public List<object> GetCorrectAnswers()
        {
            return questionType.GetCorrectAnswers();
        }

        public void RemoveAnswer(object answer)
        {
            questionType.RemoveAnswer(answer);
        }

        public void RemoveCorrectAnswer(object answer)
        {
            questionType.RemoveCorrectAnswer(answer);
        }
    }
}