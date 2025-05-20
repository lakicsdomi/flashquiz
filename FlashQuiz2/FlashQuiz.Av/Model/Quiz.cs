using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashQuiz.Av.Model
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
            ShuffleQuestions();
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


        public void DisplayQuizWithRetry()
        {
            Console.WriteLine($"Quiz: {QuizName}");
            ShuffleQuestions();

            var remaining = new List<Question>(Questions);
            _QuestionCount = 0;
            _CorrectAnswers = 0;

            while (remaining.Count > 0)
            {
                var toRetry = new List<Question>();
                foreach (var question in remaining)
                {
                    Console.WriteLine($"Score: {_CorrectAnswers}/{_QuestionCount}");
                    Console.WriteLine(question.QuestionText);
                    foreach (var answer in question.Answers)
                    {
                        Console.WriteLine($"{answer.Item1}: {answer.Item2}");
                    }
                    Console.Write("Please select an answer: ");
                    string userAnswer = Console.ReadLine() ?? string.Empty;
                    if (userAnswer.Equals(question.CorrectAnswer.Item1, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Correct!");
                        _CorrectAnswers++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is: {question.CorrectAnswer.Item2}");
                        toRetry.Add(question);
                    }
                    _QuestionCount++;
                }
                if (toRetry.Count > 0)
                {
                    Console.WriteLine($"\nYou have {toRetry.Count} question(s) to retry. Let's try again!\n");
                }
                remaining = toRetry;
            }
            Console.WriteLine($"\nQuiz complete! Final score: {_CorrectAnswers}/{_QuestionCount}");
        }


        private void ShuffleQuestions()
        {
            var rng = new Random();
            int n = Questions.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = Questions[k];
                Questions[k] = Questions[n];
                Questions[n] = value;
            }
        }
    }
}
