using ExamSystem.Models;

namespace ExamSystem.Exams
{
  public class PracticeExam : Exam
  {
    public PracticeExam()
        : base()
    {
    }

    public PracticeExam(
        int time,
        int numberOfQuestions,
        Subject subject)
        : base(time, numberOfQuestions, subject)
    {
    }

    public override void ShowExam()
    {
      Console.WriteLine();
      Console.WriteLine("================================");
      Console.WriteLine("         PRACTICE EXAM");
      Console.WriteLine("================================");

      Console.WriteLine($"Subject: {Subject.Name}");
      Console.WriteLine($"Time: {Time} Minutes");
      Console.WriteLine($"Questions: {NumberOfQuestions}");
      Console.WriteLine($"Mode: {Mode}");

      Console.WriteLine();

      foreach (Question question in Questions)
      {
        Console.WriteLine(question);

        foreach (var answer in question.AnswerList)
        {
          Console.WriteLine(answer);
        }

        Console.WriteLine();
      }

      if (Mode == ExamSystem.Enums.ExamMode.Finished)
      {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Correct Answers:");
        Console.WriteLine("--------------------------------");

        foreach (Question question in Questions)
        {
          if (question is TrueFalseQuestion trueFalseQuestion)
          {
            Console.WriteLine(
                $"{question.Header}: " +
                $"{(trueFalseQuestion.CorrectAnswer ? "True" : "False")}");
          }
          else if (question is ChooseOneQuestion chooseOneQuestion)
          {
            Console.WriteLine(
                $"{question.Header}: " +
                $"Answer #{chooseOneQuestion.CorrectAnswerId}");
          }
          else if (question is ChooseAllQuestion chooseAllQuestion)
          {
            Console.WriteLine(
                $"{question.Header}: " +
                $"Answers #{string.Join(", ", chooseAllQuestion.CorrectAnswerIds)}");
          }
        }
      }
    }
  }
}
