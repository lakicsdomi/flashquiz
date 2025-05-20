using FlashQuiz.Av.Persistence;

namespace FlashQuiz.Av.Model
{
    public class Model
    {
        public Model()
        {
            var questions = Persistence.QuestionLoader.LoadQuestions(new System.Uri("Assets/beugro.txt"));
            var quiz = new Quiz("Beugró Quiz", questions);
            quiz.DisplayQuizWithRetry();
        }

    }
}
