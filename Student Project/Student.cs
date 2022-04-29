using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Project
{
    class Student
    {
        string name { get; set; }
        int Age { get; set; }
        string Course { get; set; }
        string ID { get; set; } = Guid.NewGuid().ToString();
        string Section { get; set; }

        public Student(string name, int age, string course, String section)
        {
            this.name = name;
            this.Age = age;
            this.Course = course;
            this.Section = section;
        }

        public void print()
        {
            Console.WriteLine(name + "'s info");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Age: "+ Age);
            Console.WriteLine("Course: "+ Course);
            Console.WriteLine("Section: "+ Section);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
        }

    }
}
