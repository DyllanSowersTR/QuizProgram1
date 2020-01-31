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
            IQuestion question1 = new TrueFalseQuestion();
            question1.question = "Is blue a color?";
            question1.addCorrectAnswer(true);

            IQuestion question2 = new MultipleChoiceQuestion();
            question2.question = "How many states are there in the United States of America?";
            question2.addAnswer(25);
            question2.addAnswer(75);
            question2.addAnswer(50);
            question2.addCorrectAnswer(50);
        }
    }
}