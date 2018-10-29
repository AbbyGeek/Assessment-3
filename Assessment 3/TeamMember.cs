using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class TeamMember : Person
    {
        
            public double Salary { set; get; }
            public string Address { set; get; }

            public  TeamMember(string firstName, string lastName, int Age, string email, double salary, string address) : base(firstName, lastName, Age, email )
            {
                Salary = salary;
                Address = address;
            }

            public override void AddPerson(List<object> People)
            {
                base.AddPerson(List<object> People);
                Console.WriteLine("What is the salary of your Team Member?");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine("What is the address of your Team Member?");
                string address = Console.ReadLine();

            List<object> addedPerson = new List<object> { FirstName, LastName, Age, Email, Salary, Address };

            return addedPerson;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Address: {Address}");
        }


    }
}
