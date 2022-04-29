using Student_Project;
using System;

namespace Student_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();
            List<Course> courseList = new List<Course>();

            studentList.Add(new Student("Sakshi", 18, "Biology", "A"));
            studentList.Add(new Student("Anant", 20, "History", "C"));
            studentList.Add(new Student("Suraj", 17, "Chemistry", "B"));
            studentList.Add(new Student("Deepak", 18, "Physics", "A"));

            Console.WriteLine("-----------Student's info-------------------\n");
            foreach (Student student in studentList)
            {
                student.print();
            }

            teacherList.Add(new Teacher("Sukanth", "Biology", "Zoology"));
            teacherList.Add(new Teacher("Arun", "History", "Indian History"));
            teacherList.Add(new Teacher("Harish", "Chemistry", "Organic Chemistry"));
            teacherList.Add(new Teacher("Sukanya", "Physics", "Laser and wave technology"));

            Console.WriteLine("-----------Teacher's info-------------------\n");
            foreach (Teacher teacher in teacherList)
            {
                teacher.print();
            }

            Console.WriteLine("-----------Course info-------------------\n");
            courseList.Add(new Course("Biology", "6 Months"));
            courseList.Add(new Course("History", "6 Months"));
            courseList.Add(new Course("Chemistry", "6 Months"));
            courseList.Add(new Course("Physics", "6 Months"));

            foreach (Course course in courseList)
            {
                course.print();
            }
        }
    }
}