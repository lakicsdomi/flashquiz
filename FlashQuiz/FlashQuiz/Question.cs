using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashQuiz
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<Tuple<string, string>> Answers { get; set; }
        public Tuple<string, string> CorrectAnswer { get; set; }

        public Question(string questionText, List<Tuple<string, string>> answers, Tuple<string, string> correctAnswer)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
    }
}
