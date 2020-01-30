using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            quiz.ShowQuestions(quiz.MultipleChoiceQuestions);
            quiz.ShowQuestions(quiz.TrueFalseQuestions);
            Console.ReadKey();
        }
    }
}
