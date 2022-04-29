using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Project
{
    internal class Teacher
    {
        string name { get; set; }
        string Course { get; set; }
        string Major { get; set; }
        string ID { get; set; } = Guid.NewGuid().ToString();

        public Teacher(string name, string course, string Major)
        {
            this.name = name;
            this.Course = course;
            this.Major = Major;
        }

        public void print()
        {
            Console.WriteLine(name + "'s info");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Major: "+ Major);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
        }
    }
}
