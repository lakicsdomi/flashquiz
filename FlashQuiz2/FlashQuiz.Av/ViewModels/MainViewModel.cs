using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlashQuiz.Av.Model;
using Avalonia.Platform;
namespace FlashQuiz.Av.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly Quiz _quiz;
    private int _currentQuestionIndex;
    private int _score;
    private bool _canProceed;
    private AnswerViewModel? _selectedAnswer;

    public MainViewModel()
    {
        var questions = Persistence.QuestionLoader.LoadQuestions(new System.Uri("avares://FlashQuiz.Av/Assets/beugro.txt"));
        _quiz = new Quiz("Beugró Quiz", questions);
        _currentQuestionIndex = 0;
        _score = 0;
        Answers = new ObservableCollection<AnswerViewModel>();
        ProceedCommand = new RelayCommand(Proceed, () => CanProceed);
        AnswerCommand = new RelayCommand<AnswerViewModel>(SelectAnswer);

        LoadCurrentQuestion();
    }

    public string Score => $"Score: {_score}/{_currentQuestionIndex}";
    public string? Greeting => "Welcome to Avalonia!";

    public string? CurrentQuestionText => CurrentQuestion?.QuestionText;

    public ObservableCollection<AnswerViewModel> Answers { get; }

    public IRelayCommand ProceedCommand { get; }
    public IRelayCommand<AnswerViewModel> AnswerCommand { get; }

    public bool CanProceed
    {
        get => _canProceed;
        set
        {
            SetProperty(ref _canProceed, value);
            ProceedCommand.NotifyCanExecuteChanged();
        }
    }

    private Question? CurrentQuestion =>
        (_quiz.Questions.Count > _currentQuestionIndex)
            ? _quiz.Questions[_currentQuestionIndex]
            : null;

    private void LoadCurrentQuestion()
    {
        Answers.Clear();
        if (CurrentQuestion != null)
        {
            foreach (var answer in CurrentQuestion.Answers)
            {
                Answers.Add(new AnswerViewModel
                {
                    Text = answer.Item2,
                    Letter = answer.Item1
                });
            }
        }
        CanProceed = false;
        _selectedAnswer = null;
        OnPropertyChanged(nameof(CurrentQuestionText));
        OnPropertyChanged(nameof(Score));
    }

    private void SelectAnswer(AnswerViewModel? answer)
    {
        _selectedAnswer = answer;
        CanProceed = true;

        if (CurrentQuestion == null || answer == null)
            return;

        foreach (var ans in Answers)
        {
            // Mark the correct answer green
            if (ans.Letter == CurrentQuestion.CorrectAnswer.Item1)
            {
                ans.BackgroundColor = "#90EE90"; // LightGreen
            }
            // If this is the selected answer and it's wrong, mark it red
            else if (ans == answer)
            {
                ans.BackgroundColor = "#FFB6C1"; // LightCoral
            }
            else
            {
                ans.BackgroundColor = "#FFFFFF"; // White (default)
            }

        }
    }


    private void Proceed()
    {
        if (_selectedAnswer != null && CurrentQuestion != null)
        {
            if (_selectedAnswer.Letter == CurrentQuestion.CorrectAnswer.Item1)
            {
                _score++;
            }
        }
        _currentQuestionIndex++;
        if (_currentQuestionIndex < _quiz.Questions.Count)
        {
            LoadCurrentQuestion();
        }
        else
        {
            // Quiz finished, handle as needed
        }
    }
}

public class AnswerViewModel : ObservableObject
{
    public string? Text { get; set; }
    public string? Letter { get; set; }

    private string? _backgroundColor = "#FFFFFF";
    public string? BackgroundColor
    {
        get => _backgroundColor;
        set => SetProperty(ref _backgroundColor, value);
    }
}
