using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram1
{
    public class Quiz
    {
        public List<QuizQuestion> MultipleChoiceQuestions = new List<QuizQuestion>();
        public List<QuizQuestion> TrueFalseQuestions = new List<QuizQuestion>();
        private QuizQuestion aQuizQuestion1 = new QuizQuestion();
        private QuizQuestion aQuizQuestion2 = new QuizQuestion();
        private QuizQuestion aQuizQuestion3 = new QuizQuestion();
        private QuizQuestion aQuizQuestion4 = new TrueFalseQuestion();
        private QuizQuestion aQuizQuestion5 = new TrueFalseQuestion();
        private QuizQuestion aQuizQuestion6 = new TrueFalseQuestion();

        public Quiz()
        {
            aQuizQuestion1.Question = "Which language came first?";
            aQuizQuestion1.Answer1 = "C";
            aQuizQuestion1.Answer2 = "C++";
            aQuizQuestion1.Answer3 = "Java";
            aQuizQuestion1.Answer4 = "C#";
            aQuizQuestion1.CorrectAnswer = "C";

            aQuizQuestion2.Question = "Which of the following is not a JavaScript framework?";
            aQuizQuestion2.Answer1 = "React";
            aQuizQuestion2.Answer2 = "Iris";
            aQuizQuestion2.Answer3 = "Angular";
            aQuizQuestion2.Answer4 = "Aurelia";
            aQuizQuestion2.CorrectAnswer = "Iris";

            aQuizQuestion3.Question = "The lightest Linux flavour is: ";
            aQuizQuestion3.Answer1 = "Ubuntu";
            aQuizQuestion3.Answer2 = "Kubuntu";
            aQuizQuestion3.Answer3 = "Lubuntu";
            aQuizQuestion3.Answer4 = "Kali Linux";
            aQuizQuestion3.CorrectAnswer = "Lubuntu";

            aQuizQuestion4.Question = "Java is an Object Oriented Language";
            aQuizQuestion4.CorrectAnswer = "True";

            aQuizQuestion5.Question = "You can use `docker delete` to remove a docker container";
            aQuizQuestion5.CorrectAnswer = "False";

            aQuizQuestion6.Question = "ls -la displays hidden files";
            aQuizQuestion6.CorrectAnswer = "True";

            MultipleChoiceQuestions.Add(aQuizQuestion1);
            MultipleChoiceQuestions.Add(aQuizQuestion2);
            MultipleChoiceQuestions.Add(aQuizQuestion3);
            TrueFalseQuestions.Add(aQuizQuestion4);
            TrueFalseQuestions.Add(aQuizQuestion5);
            TrueFalseQuestions.Add(aQuizQuestion6);

        }

        public string Format(QuizQuestion quizQuestion)
        {
            string message = "";
            message = message + quizQuestion.Question + "\n";
            message = message + quizQuestion.Answer1 + "\n";
            message = message + quizQuestion.Answer2 + "\n";
            message = message + quizQuestion.Answer3 + "\n";
            message = message + quizQuestion.Answer4 + "\n";

            return message;
        }

        public void ShowQuestions(List<QuizQuestion> questions)
        {

            foreach (var question in questions)
            {
                Console.WriteLine(Format(question));
            }
        }
    }
}
