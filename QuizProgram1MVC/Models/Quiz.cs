using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProgram1MVC.Models
{
    public class Quiz
    {
        public List<IQuestion> questions = new List<IQuestion>();
        private IQuizFormatter quizFormatter;

        public Quiz(IQuizFormatter quizFormatter)
        {
            this.quizFormatter = quizFormatter;
        }

        public void AddQuestion(IQuestion question)
        {
            questions.Add(question);
        }

        public void RemoveQuestion(IQuestion question)
        {
            questions.Remove(question);
        }

        public string GetQuestions()
        {
            string questionsStr = "";

            foreach (IQuestion question in questions)
            {
                questionsStr += quizFormatter.Format(question);
            }

            return questionsStr;
        }
    }
}