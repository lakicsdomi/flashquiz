# FlashQuiz

FlashQuiz is a simple console-based quizzing app for studying and knowledge reinforcement. Built entirely in C#, it loads quizzes from a text resource file and lets you take them right in your terminal.

![eaf3861c-9270-4c2c-b077-4e1c36a87201](https://github.com/user-attachments/assets/0436c9a6-ddad-4b26-b8f3-389c76af44c5)

![7de437f1-5090-4cd9-8ca6-672783825c04](https://github.com/user-attachments/assets/e3e3a474-edca-4888-92bc-a2060463d152)



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
