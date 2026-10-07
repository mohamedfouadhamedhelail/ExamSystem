using ExamSystem.Collections;
using ExamSystem.Enums;
using ExamSystem.Models;
using ExamSystem.Notifications;

namespace ExamSystem.Exams
{
  public abstract class Exam
  {
    public int Time { get; set; }

    public int NumberOfQuestions { get; set; }

    public QuestionList Questions { get; set; }

    public Dictionary<Question, AnswerList> QuestionAnswers { get; set; }

    public Subject Subject { get; set; }

    public ExamMode Mode { get; private set; }

    public ExamNotification Notification { get; set; }

    protected Exam()
    {
      Questions = new QuestionList(
          $"Questions_{Guid.NewGuid()}.txt"
      );

      QuestionAnswers =
          new Dictionary<Question, AnswerList>();

      Subject = new Subject();

      Mode = ExamMode.Queued;

      Notification =
          new ExamNotification();
    }

    protected Exam(
        int time,
        int numberOfQuestions,
        Subject subject)
        : this()
    {
      Time = time;
      NumberOfQuestions = numberOfQuestions;
      Subject = subject;
    }

    public void Start()
    {
      Mode = ExamMode.Starting;

      Notification.Notify(this);
    }

    public void Finish()
    {
      Mode = ExamMode.Finished;
    }

    public abstract void ShowExam();

    public override string ToString()
    {
      return $"{Subject.Name} - {NumberOfQuestions} Questions - {Time} Minutes";
    }

    public override bool Equals(object? obj)
    {
      if (obj is not Exam other)
        return false;

      return Subject.Equals(other.Subject)
             && Time == other.Time
             && NumberOfQuestions == other.NumberOfQuestions;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(
          Subject,
          Time,
          NumberOfQuestions);
    }
  }
}
