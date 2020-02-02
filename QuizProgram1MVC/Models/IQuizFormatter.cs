using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram1MVC.Models
{
    public interface IQuizFormatter
    {
        string Format(IQuestion question);
    }
}
