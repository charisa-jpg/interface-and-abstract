using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_and_abstract
{
    public class Student : Person, IRegistrable
    {
        public string StudentId { get; set; }
        public string Major { get; set; }

        public void RegisterTraining()
        {
            Console.WriteLine("Student registered for training.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[Student] {FirstName} {LastName} | ID: {StudentId} | Major: {Major}");
        }
    }
}