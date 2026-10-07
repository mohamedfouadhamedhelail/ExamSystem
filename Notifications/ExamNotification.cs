using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Notifications
{
  public delegate void ExamStartedHandler(object sender, Exam exam);

  public class ExamNotification
  {
    public event ExamStartedHandler? ExamStarted;

    public void Notify(Exam exam)
    {
      ExamStarted?.Invoke(this, exam);
    }
  }
}
