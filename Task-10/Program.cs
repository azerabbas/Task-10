using System;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolPerson schoolPerson = new SchoolPerson();
            schoolPerson.Name = "Azer";
            schoolPerson.Surname = "Abbas";
            schoolPerson.Greet();

            Student student = new Student();
            student.Name = "Araz";
            student.Surname = "Abbasli";
            student.DateOfBirth = 2001;
            student.Greet();
            student.ShowAge();
            student.GoToClasses();

            Theacher theacher = new Theacher();
            theacher.Name = "Tamerlan";
            theacher.Surname = "Farzullali";
            theacher.DateOfBirth = 1992;
            theacher.Greet();
            theacher.GoToClasses();
            theacher.Explain();


        }
         
    }
}
