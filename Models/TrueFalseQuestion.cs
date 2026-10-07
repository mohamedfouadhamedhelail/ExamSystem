namespace ExamSystem.Models
{
  public class TrueFalseQuestion : Question
  {
    public bool CorrectAnswer { get; set; }

    public TrueFalseQuestion()
        : base()
    {
    }

    public TrueFalseQuestion(
        string header,
        string body,
        int marks,
        bool correctAnswer)
        : base(header, body, marks)
    {
      CorrectAnswer = correctAnswer;

      AnswerList.Add(new Answer(1, "True"));
      AnswerList.Add(new Answer(2, "False"));
    }

    public override string ToString()
    {
      return $"{Header}: {Body} ({Marks} Marks)";
    }
  }
}
