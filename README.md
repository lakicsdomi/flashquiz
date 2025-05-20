# FlashQuiz

FlashQuiz is a simple console-based quizzing app for studying and knowledge reinforcement. Built entirely in C#, it loads quizzes from a text resource file and lets you take them right in your terminal.

![6e82df73-4a1c-4634-84c8-206193ecd1ac](https://github.com/user-attachments/assets/5a2c04d5-0eba-4733-8e7b-0fdeaffeeb66)


## Features

- **Loads Questions from File:** Questions and answers are read from a local text file (`Resources/beugro.txt`).
- **Multiple Choice Questions:** Each question can have up to four possible answers (a-d), with one correct answer.
- **Console Interaction:** Presents questions and choices in the terminal, accepts your answer, and gives instant feedback.
- **Score Tracking:** Shows your current score after each question.
- **.NET 8.0 Project:** Built using modern C# and .NET 8.0 features.

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
- A compatible IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository:**
    ```bash
    git clone https://github.com/lakicsdomi/flashquiz.git
    cd flashquiz
    ```

2. **Build the project:**
    ```bash
    dotnet build
    ```

3. **Run the application:**
    ```bash
    dotnet run --project FlashQuiz/FlashQuiz
    ```

## Usage

1. Make sure `Resources/beugro.txt` contains your questions in the correct format.
2. Run the application.
3. Answer each question by typing the letter (a, b, c, or d).
4. See your score update after each question.

### Question File Format

- Each question starts with a number and a dot:
    ```
    1. What is 2+2?
    X a. 4
      b. 3
      c. 2
      d. 5
    ```
- Correct answers are marked with an `X` before the answer letter.

## Project Structure

- `FlashQuiz/FlashQuiz/Program.cs` — Main entry point
- `FlashQuiz/FlashQuiz/QuestionLoader.cs` — Loads questions from file
- `FlashQuiz/FlashQuiz/Quiz.cs` — Quiz logic and score tracking
- `FlashQuiz/FlashQuiz/Question.cs` — Question model
- `FlashQuiz/FlashQuiz/Resources/beugro.txt` — Sample questions

## Contributing

Contributions are welcome! Open an issue or submit a pull request to propose changes or report bugs.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
