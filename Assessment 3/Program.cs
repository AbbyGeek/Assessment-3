using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> people = new List<object>
            {
                new TeamMember("Greg", "Universe", 41, "Greg@Universe.com", 40000, "123 Car wash"),
                new TeamMember("Rose", "Quartz", 10000, "Rose@CrysytalGem.com", 0, "Beach House")
            };

            
            Console.WriteLine("Would you like to add to your list of friends? (y/n)");
            string ans = Console.ReadLine().ToLower();
            if (ans == "y")
            {
                //
                people.Add(TeamMember.AddPerson(people));
            }

            
            for (int i = 0; i < people.Count; i++)
            {
                people[i].Print();

            }
            Console.ReadLine();
                            
            }
            
        
        }
    }
