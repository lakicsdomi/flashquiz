namespace FlashQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionLoader.LoadQuestions("Resources/beugro.txt");
            var quiz = new Quiz("Beugró Quiz", questions);
            quiz.DisplayQuizWithRetry();
        }
    }
}
