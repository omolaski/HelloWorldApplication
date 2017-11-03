using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTestApplication
{
    class Program
    {
        class Student
        {
            public int age { get; set; }
            public string name { get; set; }
        }
        static void Main(string[] args)
        {
            Student student = new Student();

            student.age = 45;
            student.name = "Kehinde Lydia Topeyemi";

            Console.WriteLine("Hello, " + student.name + " I am " + student.age.ToString() + " year old");
            Console.WriteLine("We are here");
        }
    }
}
