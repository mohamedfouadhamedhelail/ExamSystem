using ExamSystem.Collections;

namespace ExamSystem.Models
{
  public abstract class Question : ICloneable, IComparable<Question>
  {
    public string Header { get; set; }

    public string Body { get; set; }

    public int Marks { get; set; }

    public AnswerList AnswerList { get; set; }

    protected Question()
    {
      Header = string.Empty;
      Body = string.Empty;
      AnswerList = new AnswerList();
    }

    protected Question(
        string header,
        string body,
        int marks)
        : this()
    {
      Header = header;
      Body = body;
      Marks = marks;
    }

    public override string ToString()
    {
      return $"{Header}: {Body} - Marks: {Marks}";
    }

    public object Clone()
    {
      Question clonedQuestion =
          (Question)this.MemberwiseClone();

      clonedQuestion.AnswerList = new AnswerList();

      foreach (var answer in AnswerList)
      {
        clonedQuestion.AnswerList.Add(
            new Answer(answer.Id, answer.Text));
      }

      return clonedQuestion;
    }

    public int CompareTo(Question? other)
    {
      if (other == null)
        return 1;

      return Marks.CompareTo(other.Marks);
    }
  }
}
