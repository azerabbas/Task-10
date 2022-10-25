using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    public class SchoolPerson
    {
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DateOfBirth { get; set; }
        public string CurrentClass { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello {Name} {Surname}");
        }

        public virtual void GoToClasses()
        {
            Console.WriteLine($"{Name} {Surname} I'm student and i'm going to class");
        }

        public void ShowAge()
        {
            int yash = DateTime.Now.Year - DateOfBirth;

            while (yash<=6&&yash>50)
            {
                Console.WriteLine("Error: Plase try again");
            }
            Console.WriteLine($"My age is {yash} years old");

        }

    }


}
