namespace ExamSystem.Models
{
  public class Subject
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public Subject()
    {
      Name = string.Empty;
    }

    public Subject(int id, string name)
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
      if (obj is not Subject other)
        return false;

      return Id == other.Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}
