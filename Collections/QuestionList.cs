using ExamSystem.Models;

namespace ExamSystem.Collections
{
  public class QuestionList : List<Question>
  {
    public string FilePath { get; set; }

    public QuestionList(string filePath)
    {
      FilePath = filePath;
    }

    public new void Add(Question question)
    {
      // Default Add behavior
      base.Add(question);

      // Log question into file
      using (TextWriter writer = new StreamWriter(FilePath, true))
      {
        writer.WriteLine(question.ToString());
      }
    }
  }
}
