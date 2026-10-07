namespace ExamSystem.Models
{
  public class ChooseAllQuestion : Question
  {
    public List<int> CorrectAnswerIds { get; set; }

    public ChooseAllQuestion()
        : base()
    {
      CorrectAnswerIds = new List<int>();
    }

    public ChooseAllQuestion(
        string header,
        string body,
        int marks,
        List<int> correctAnswerIds)
        : base(header, body, marks)
    {
      CorrectAnswerIds = correctAnswerIds;
    }

    public override string ToString()
    {
      return $"{Header}: {Body} ({Marks} Marks)";
    }
  }
}
