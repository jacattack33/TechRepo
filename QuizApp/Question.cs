using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public abstract class Question
    {
        public string QuestionString { get; set; }
        public int Points { get; set; }

        public Question(string questionString, int points)
        {
            QuestionString = questionString;
            Points = points;
        }

        public abstract void DisplayQuestion();
        //method displays question string

        public abstract void DisplayChoices();
        //displays choices

        public void GetUserInput();
    }
}
