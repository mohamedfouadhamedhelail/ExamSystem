using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Notifications
{
  public class Student
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public Student()
    {
      Name = string.Empty;
    }

    public Student(int id, string name)
        : this()
    {
      Id = id;
      Name = name;
    }

    public override string ToString()
    {
      return $"{Id} - {Name}";
    }

    public override bool Equals(object? obj)
    {
      if (obj is not Student other)
        return false;

      return Id == other.Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}
