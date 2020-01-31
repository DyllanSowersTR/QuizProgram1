using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram1MVC.Models
{
    public interface IQuestion
    {
        string question { get; set; }

        List<object> getAnswers();
        void addAnswer(object answer);
        void removeAnswer(object answer);

        List<object> getCorrectAnswers();
        void addCorrectAnswer(object answer);
        void removeCorrectAnswer(object answer);
    }
}
