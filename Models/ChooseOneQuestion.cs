namespace ExamSystem.Models
{
  public class ChooseOneQuestion : Question
  {
    public int CorrectAnswerId { get; set; }

    public ChooseOneQuestion()
        : base()
    {
    }

    public ChooseOneQuestion(
        string header,
        string body,
        int marks,
        int correctAnswerId)
        : base(header, body, marks)
    {
      CorrectAnswerId = correctAnswerId;
    }

    public override string ToString()
    {
      return $"{Header}: {Body} ({Marks} Marks)";
    }
  }
}
