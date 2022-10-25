using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    public class Theacher : SchoolPerson
    {
        protected string subject;
        
        public void Explain()
        {
            Console.WriteLine($"Explanation begin on {subject}");
        }

        public override void GoToClasses()
        {
            Console.WriteLine($"i'm {Name} {Surname}, I'm a teacher and i'm going to class");
        }
    } 
}
