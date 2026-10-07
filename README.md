# Examination System

An Object-Oriented Examination System built with C# to demonstrate core OOP concepts, inheritance, abstraction, interfaces, collections, events, delegates, and file handling.

## 📌 About The Project

This project implements a simple examination system that supports different types of questions and two types of exams.

The system was designed around an abstract `Question` class with different question types inheriting from it:

- True / False
- Choose One
- Choose All

It also includes Practice and Final exams with different behaviors.

## ✨ Features

- Abstract base `Question` class
- Multiple question types using inheritance
- `Answer` and `AnswerList` classes
- Custom `QuestionList` inherited from `List<Question>`
- Question logging to text files
- Abstract `Exam` base class
- Practice Exam
- Final Exam
- Subject association
- Question/Answer dictionary for exam correction
- Exam modes:
  - Starting
  - Queued
  - Finished
- Student notification system
- Events and Delegates
- `ICloneable` implementation
- `IComparable<Question>` implementation
- `ToString()` overrides
- `Equals()` and `GetHashCode()` overrides
- Constructor chaining
- Generic collections

## 🏗️ Project Structure

```text
ExamSystem
│
├── Collections
│   ├── AnswerList.cs
│   └── QuestionList.cs
│
├── Enums
│   └── ExamMode.cs
│
├── Exams
│   ├── Exam.cs
│   ├── FinalExam.cs
│   └── PracticeExam.cs
│
├── Models
│   ├── Answer.cs
│   ├── ChooseAllQuestion.cs
│   ├── ChooseOneQuestion.cs
│   ├── Question.cs
│   ├── Subject.cs
│   └── TrueFalseQuestion.cs
│
├── Notifications
│   ├── ExamNotification.cs
│   └── Student.cs
│
└── Program.cs
