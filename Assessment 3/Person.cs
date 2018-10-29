using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class Person
    {
        //create class Person
        //create properties First Name, Last Name, Age, Email, Is Adult.
        //add constructor that takes the following parameter list. First Name, Last Name, Age, Email
        //Bool method to determine if adult
        // method to add someone to list.

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool Adult { get; set; }

        public Person(string firstName, string lastName, int age, string email, bool adult)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Adult = adult;
        }
        
        public static bool IsAdult(int age)
        {
            return age >= 18;
        }

        public virtual void AddPerson(List<object> People)
        {
            while (true)
            {
                try
                {
                    
                    
                    Console.WriteLine("What is the first name of the person you are adding?");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("What is the last name of the person you are adding?");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("What is the age of the person we are adding?");
                    int Age = int.Parse(Console.ReadLine());

                    bool Adult = IsAdult(Age);
                    if (Adult == false)
                    {
                        Console.WriteLine("This person does not meet the age requirements to be on this list. Please try again, or press 'q' to quit or any other key to continue.");
                        string entry = Console.ReadLine();
                            if (entry == "q") { break; }
                            else { continue; }
                    }

                    Console.WriteLine("What is the email address of the person you are adding?");
                    string Email = Console.ReadLine();

                    List<object> addedPerson = new List<object> {FirstName, LastName, Age, Email };

                    
                    
                }
                catch
                {
                    Console.WriteLine("Invalid Entry. Please Try Again.");
                    continue;
                }

            }

        }

        public virtual void Print()
        {
            Console.WriteLine($"\nName: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
        }


       
        
    }
}
