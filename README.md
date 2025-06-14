# FlashQuiz

FlashQuiz is a simple quiz application for practicing questions and answers from a file. The repository contains **two separate projects**:

---

## Projects Overview

This project was inspired when I needed a quizzing app for studying for my **Software technologies** subject. I didn't like the other apps on the internet, because they didn't have the functionalities I wanted, so I made my own.

### 1. FlashQuiz (Console)

- **Type:** Console application
- **Description:**  
  A command-line tool where you can load questions from a file, answer them interactively, and the program keeps track of your score.
- **Key Features:**
  - Load questions from a file
  - Answer questions via the console
  - Score tracking
- **Project Path:** `FlashQuiz/`


---

### 2. FlashQuiz2 (GUI with Avalonia UI)

- **Type:** GUI application (cross-platform (Android and Windows), Avalonia UI)
- **Description:**  
  A graphical version of FlashQuiz. It provides a user-friendly interface for loading questions, answering them, and viewing your score.
- **Key Features:**
  - Load questions from a file
  - Intuitive graphical interface (Avalonia UI)
  - Real-time scoring
  - Progress tracking
- **Project Path:** `FlashQuiz2/`

---

## How To Use

### Running the Console Version

1. Navigate to the `FlashQuiz` directory.
2. Build and run the application using your preferred .NET toolchain.
3. Follow the on-screen prompts to load a question file and start answering.

### Running the GUI Version

1. Navigate to the `FlashQuiz2` directory.
2. Build and run the application.
3. Use the graphical interface to load your question file and answer questions.

---

## Screenshots

### FlashQuiz

![image](https://github.com/user-attachments/assets/5653fb3c-5fbd-4946-9c86-55d6860e81e8)

### FlashQuiz2 (GUI)

![image](Documentation/Screenshots/desktop1.jpeg)
You can find more screenshots [here](Documentation/Screenshots).

---

## Question File Format

Questions must be provided in a specific file format. Please refer to the documentation inside each project for sample files and format details.
It should look like this:

```
1. Question one
a. Wrong answer 1
b. Wrong answer 2
X c. Correct answer 3
```

Each question has a letter in front of it, and the correct answer also has a capital X in front of it.

---

## Requirements

- .NET SDK (for building and running)
- Avalonia UI dependencies (for FlashQuiz2 GUI version)

---

## License

This project is licensed under the MIT License.

---

## Contributing

Feel free to open issues or submit pull requests if you'd like to contribute or suggest improvements.
