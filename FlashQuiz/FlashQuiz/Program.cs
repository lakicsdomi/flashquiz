namespace FlashQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var questions = QuestionLoader.LoadQuestions("Resources/beugro.txt");
            var quiz = new Quiz("Beugró Quiz", questions);
            quiz.DisplayQuiz();
        }
    }
}
