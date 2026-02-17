using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_and_abstract
{
    public class GeneralPerson : Person, IRegistrable, ISpeaker
    {
        public string Workplace { get; set; }
        public string Position { get; set; }

        public void RegisterTraining()
        {
            Console.WriteLine("General person registered for training.");
        }

        public void ConductTraining()
        {
            Console.WriteLine("General person is conducting training.");
        }

        public void ApproveResult()
        {
            Console.WriteLine("General person approved training result.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[GeneralPerson] {FirstName} {LastName} | {Workplace} | {Position}");
        }
    }
}