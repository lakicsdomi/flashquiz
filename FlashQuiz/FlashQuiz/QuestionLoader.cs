using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FlashQuiz
{
    public static class QuestionLoader
    {
        public static List<Question> LoadQuestions(string filePath)
        {
            var questions = new List<Question>();
            var lines = File.ReadAllLines(filePath);
            int i = 0;
            while (i < lines.Length)
            {
                // Skip empty lines
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    i++;
                    continue;
                }

                // Question line: starts with number and dot
                var questionMatch = Regex.Match(lines[i], @"^\d+\.\s+(.*)");
                if (!questionMatch.Success)
                {
                    i++;
                    continue;
                }
                string questionText = questionMatch.Groups[1].Value.Trim();
                i++;

                var answers = new List<Tuple<string, string>>();
                Tuple<string, string>? correctAnswer = null;

                // Read up to 4 answers (a-d)
                for (int answerCount = 0; answerCount < 4 && i < lines.Length; answerCount++, i++)
                {
                    var answerLine = lines[i].Trim();
                    var answerMatch = Regex.Match(answerLine, @"^(X\s*)?([a-d])\.\s+(.*)");
                    if (!answerMatch.Success)
                        break;

                    bool isCorrect = !string.IsNullOrEmpty(answerMatch.Groups[1].Value);
                    string letter = answerMatch.Groups[2].Value;
                    string text = answerMatch.Groups[3].Value.Trim();

                    var answerTuple = Tuple.Create(letter, text);
                    answers.Add(answerTuple);
                    if (isCorrect)
                        correctAnswer = answerTuple;
                }

                if (answers.Count > 0 && correctAnswer != null)
                {
                    questions.Add(new Question(questionText, answers, correctAnswer));
                }

                // Skip any blank lines between questions
                while (i < lines.Length && string.IsNullOrWhiteSpace(lines[i]))
                    i++;
            }
            return questions;
        }
    }
}
