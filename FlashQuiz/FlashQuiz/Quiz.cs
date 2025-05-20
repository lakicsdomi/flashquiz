using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashQuiz
{
    public class Quiz
    {
        public string QuizName { get; set; }
        private int _QuestionCount;
        private int _CorrectAnswers;
        
        public List<Question> Questions { get; set; }
        public Quiz(string quizName, List<Question> questions)
        {
            QuizName = quizName;
            Questions = questions;
        }
        public void DisplayQuiz()
        {
            Console.WriteLine($"Quiz: {QuizName}");
            foreach (var question in Questions)
            {
                Console.WriteLine($"Score: {_CorrectAnswers}/{_QuestionCount}");
                Console.WriteLine(question.QuestionText);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answer.Item1}: {answer.Item2}");
                }
                Console.Write("Please select an answer: ");
                string userAnswer = Console.ReadLine() ?? string.Empty;
                if(userAnswer.Equals(question.CorrectAnswer.Item1, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                    _CorrectAnswers++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {question.CorrectAnswer.Item2}");
                }
                _QuestionCount++;
            }
        }
    }
}
