using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_and_abstract
{
    public class Teacher : Person, IRegistrable, ISpeaker
    {
        public string Major { get; set; }
        public string AcademicPosition { get; set; }

        public void RegisterTraining()
        {
            Console.WriteLine("Teacher registered for training.");
        }

        public void ConductTraining()
        {
            Console.WriteLine("Teacher is conducting training.");
        }

        public void ApproveResult()
        {
            Console.WriteLine("Teacher approved training result.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[Teacher] {FirstName} {LastName} | {AcademicPosition} | Major: {Major}");
        }
    }
}
