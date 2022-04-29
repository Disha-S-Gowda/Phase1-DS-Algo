using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Storage_System
{
    class Teacher
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public Teacher(string name, string Class, string Section)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Name = name;
            this.Section = Section;
            this.Class = Class; 
        }

        public void print()
        {
            Console.WriteLine(Name + "'s info");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Section: " + Section);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
        }
    }
}
