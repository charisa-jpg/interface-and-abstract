using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_and_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> trainees = new List<Person>();
            List<ISpeaker> speakers = new List<ISpeaker>();

            while (true)
            {
                Console.WriteLine("\n===== Training Registration =====");
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Teacher");
                Console.WriteLine("3. General Person");
                Console.WriteLine("4. Show Trainees");
                Console.WriteLine("5. Show Speakers");
                Console.WriteLine("0. Exit");
                Console.Write("Select: ");

                string choice = Console.ReadLine();

                if (choice == "0") break;

                if (choice == "4")
                {
                    Console.WriteLine("\n--- Trainees ---");
                    foreach (var t in trainees)
                        t.ShowInfo();
                    continue;
                }

                if (choice == "5")
                {
                    Console.WriteLine("\n--- Speakers ---");
                    foreach (var s in speakers)
                        Console.WriteLine(s.GetType().Name);
                    continue;
                }

                Person person = null;

                Console.Write("First Name: ");
                string fname = Console.ReadLine();

                Console.Write("Last Name: ");
                string lname = Console.ReadLine();

                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                if (choice == "1")
                {
                    Student s = new Student();

                    Console.Write("Student ID: ");
                    s.StudentId = Console.ReadLine();

                    Console.Write("Major: ");
                    s.Major = Console.ReadLine();

                    person = s;
                }
                else if (choice == "2")
                {
                    Teacher t = new Teacher();

                    Console.Write("Major: ");
                    t.Major = Console.ReadLine();

                    Console.Write("Academic Position: ");
                    t.AcademicPosition = Console.ReadLine();

                    person = t;
                    speakers.Add(t);
                }
                else if (choice == "3")
                {
                    GeneralPerson g = new GeneralPerson();

                    Console.Write("Workplace: ");
                    g.Workplace = Console.ReadLine();

                    Console.Write("Position: ");
                    g.Position = Console.ReadLine();

                    person = g;
                    speakers.Add(g);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                person.FirstName = fname;
                person.LastName = lname;
                person.Phone = phone;
                person.Email = email;

                trainees.Add(person);

                if (person is IRegistrable r)
                    r.RegisterTraining();

                Console.WriteLine("Register success!");
            }
        }
    }
}