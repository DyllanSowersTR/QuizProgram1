using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram1MVC.Models
{
    public interface IQuestion
    {
        string Question { get; set; }

        List<object> GetAnswers();
        void AddAnswer(object answer);
        void RemoveAnswer(object answer);

        List<object> GetCorrectAnswers();
        void AddCorrectAnswer(object answer);
        void RemoveCorrectAnswer(object answer);
    }
}
