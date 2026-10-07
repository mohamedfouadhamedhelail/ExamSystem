using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
  public class Answer
  {
    public int Id { get; set; }

    public string Text { get; set; }


    public Answer()
    {
      Text = string.Empty;
    }

    public Answer(int id, string text) : this()
    {
      Id = id;
      Text = text;
    }


    public override string ToString()
    {
      return $"{Id}. {Text}";
    }





  }
}
