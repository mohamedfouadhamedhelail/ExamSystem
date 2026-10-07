using ExamSystem.Models;

namespace ExamSystem.Exams
{
  public class FinalExam : Exam
  {
    public FinalExam()
        : base()
    {
    }

    public FinalExam(
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
      Console.WriteLine("            FINAL EXAM");
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
    }
  }
}
