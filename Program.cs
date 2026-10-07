using ExamSystem.Exams;
using ExamSystem.Models;
using ExamSystem.Notifications;

namespace ExamSystem
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // ==============================
      // Create Subject
      // ==============================

      Subject subject = new Subject(
          1,
          "Object Oriented Programming"
      );


      // ==============================
      // Create Students
      // ==============================

      Student student1 =
          new Student(1, "Mohamed");

      Student student2 =
          new Student(2, "Ahmed");

      Student student3 =
          new Student(3, "Omar");


      // ==============================
      // Create Practice Exam
      // ==============================

      PracticeExam practiceExam =
          new PracticeExam(
              60,
              3,
              subject
          );


      // ==============================
      // Create Questions
      // ==============================

      TrueFalseQuestion q1 =
          new TrueFalseQuestion(
              "Question 1",
              "C# is an object oriented programming language.",
              5,
              true
          );


      ChooseOneQuestion q2 =
          new ChooseOneQuestion(
              "Question 2",
              "Which language is used with .NET?",
              5,
              1
          );

      q2.AnswerList.Add(
          new Answer(1, "C#")
      );

      q2.AnswerList.Add(
          new Answer(2, "Java")
      );

      q2.AnswerList.Add(
          new Answer(3, "Python")
      );

      q2.AnswerList.Add(
          new Answer(4, "PHP")
      );


      ChooseAllQuestion q3 =
          new ChooseAllQuestion(
              "Question 3",
              "Which are OOP concepts?",
              10,
              new List<int> { 1, 2, 3 }
          );

      q3.AnswerList.Add(
          new Answer(1, "Encapsulation")
      );

      q3.AnswerList.Add(
          new Answer(2, "Inheritance")
      );

      q3.AnswerList.Add(
          new Answer(3, "Polymorphism")
      );

      q3.AnswerList.Add(
          new Answer(4, "HTML")
      );


      // ==============================
      // Add Questions To Exam
      // ==============================

      practiceExam.Questions.Add(q1);
      practiceExam.Questions.Add(q2);
      practiceExam.Questions.Add(q3);


      // ==============================
      // Notification
      // ==============================

      practiceExam.Notification.ExamStarted +=
          (sender, exam) =>
          {
            Console.WriteLine(
                      $"Notification: {student1.Name}, " +
                      $"your {exam.Subject.Name} exam has started."
                  );
          };


      practiceExam.Notification.ExamStarted +=
          (sender, exam) =>
          {
            Console.WriteLine(
                      $"Notification: {student2.Name}, " +
                      $"your {exam.Subject.Name} exam has started."
                  );
          };


      practiceExam.Notification.ExamStarted +=
          (sender, exam) =>
          {
            Console.WriteLine(
                      $"Notification: {student3.Name}, " +
                      $"your {exam.Subject.Name} exam has started."
                  );
          };


      // ==============================
      // Create Final Exam
      // ==============================

      FinalExam finalExam =
          new FinalExam(
              120,
              3,
              subject
          );

      finalExam.Questions.Add(
          new TrueFalseQuestion(
              "Question 1",
              "OOP supports inheritance.",
              5,
              true
          )
      );


      ChooseOneQuestion finalQ2 =
          new ChooseOneQuestion(
              "Question 2",
              "Which is a .NET language?",
              5,
              1
          );

      finalQ2.AnswerList.Add(
          new Answer(1, "C#")
      );

      finalQ2.AnswerList.Add(
          new Answer(2, "PHP")
      );

      finalQ2.AnswerList.Add(
          new Answer(3, "HTML")
      );

      finalExam.Questions.Add(finalQ2);


      // ==============================
      // User Selects Exam
      // ==============================

      Console.WriteLine("================================");
      Console.WriteLine("       EXAMINATION SYSTEM");
      Console.WriteLine("================================");

      Console.WriteLine();

      Console.WriteLine("1 - Practice Exam");
      Console.WriteLine("2 - Final Exam");

      Console.WriteLine();

      Console.Write("Select Exam Type: ");

      string? choice = Console.ReadLine();


      // ==============================
      // Show Selected Exam
      // ==============================

      if (choice == "1")
      {
        Console.Clear();

        Console.WriteLine("Starting Practice Exam...");

        practiceExam.Start();

        practiceExam.ShowExam();

        Console.WriteLine();

        Console.WriteLine(
            "Press ENTER when you finish the exam..."
        );

        Console.ReadLine();

        practiceExam.Finish();

        Console.Clear();

        practiceExam.ShowExam();
      }
      else if (choice == "2")
      {
        Console.Clear();

        Console.WriteLine("Starting Final Exam...");

        finalExam.Start();

        finalExam.ShowExam();

        Console.WriteLine();

        Console.WriteLine(
            "Press ENTER when you finish the exam..."
        );

        Console.ReadLine();

        finalExam.Finish();

        Console.WriteLine();

        Console.WriteLine(
            $"Exam Mode: {finalExam.Mode}"
        );
      }
      else
      {
        Console.WriteLine(
            "Invalid choice."
        );
      }

      Console.WriteLine();

      Console.WriteLine(
          "Press any key to exit..."
      );

      Console.ReadKey();
    }
  }
}
