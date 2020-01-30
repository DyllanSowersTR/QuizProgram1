using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram1
{
    public class QuizQuestion
    {

        protected string question = "n/a";
        protected string answer1 = "n/a";
        protected string answer2 = "n/a";
        protected string answer3 = "n/a";
        protected string answer4 = "n/a";
        protected string correctAnswer = "n/a";


        public virtual string Question
        {
            get
            {
                return this.question;
            }
            set
            {
                this.question = value;
            }
        }
        public virtual string Answer1
        {
            get
            {
                return this.answer1;
            }
            set
            {
                this.answer1 = value;
            }
        }
        public virtual string Answer2
        {
            get
            {
                return this.answer2;
            }
            set
            {
                this.answer2 = value;
            }
        }
        public virtual string Answer3
        {
            get
            {
                return this.answer3;
            }
            set
            {
                this.answer3 = value;
            }
        }
        public virtual string Answer4
        {
            get
            {
                return this.answer4;
            }
            set
            {
                this.answer4 = value;
            }
        }
        public virtual string CorrectAnswer
        {
            get
            {
                return this.correctAnswer;
            }
            set
            {
                this.correctAnswer = value;
            }
        }
    }
}
