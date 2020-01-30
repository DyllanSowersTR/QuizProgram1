using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram1
{
    public class TrueFalseQuestion : QuizQuestion
    {

        public override string Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
            }
        }

        public override string Answer1
        {
            get
            {
                return "true";
            }
            set
            {
                answer1 = "true";
            }
        }

        public override string Answer2
        {
            get
            {
                return "false";
            }
            set
            {
                answer2 = "false";
            }
        }

        public override string Answer3
        {
            get
            {
                throw new Exception("This is not defined for this quiz type");

            }
            set
            {
                throw new Exception("This is not defined for this quiz type");
            }
        }

        public override string Answer4
        {
            get
            {
                throw new Exception("This is not defined for this quiz type");

            }
            set
            {
                throw new Exception("This is not defined for this quiz type");
            }
        }


    }
}
