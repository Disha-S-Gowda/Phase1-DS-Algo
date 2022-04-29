using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Project
{
    internal class Course
    {
        string name { get; set; }
        string Duration { get; set; }
        string ID { get; set; } = Guid.NewGuid().ToString();

        public Course(string name, string Duration)
        {
            this.name = name;
            this.Duration = Duration;
        }

        public void print()
        {
            Console.WriteLine(name + " course info");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Duration: " + Duration);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
        }
    }
}
