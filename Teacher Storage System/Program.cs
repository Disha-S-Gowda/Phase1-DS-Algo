using System;

namespace Teacher_Storage_System
{
    class Program
    {

        static void Main(string[] args)
        {
            TeacherStorage teacherUtil = new TeacherStorage();
            String name, id, Class, Section;
            //teacherUtil.StoreTeacher("Tara", "Biology", "B");
            //teacherUtil.StoreTeacher("Sahana", "Maths", "B");

            while (true)
            {
                Console.WriteLine("Choose Menu \n");
                Console.WriteLine("1.Store Teacher info");
                Console.WriteLine("2.Update teacher info");
                Console.WriteLine("3.Retrieve and print teacher info");
                Console.WriteLine("4. Exit Program");

                int Menu = Int32.Parse(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                        Console.WriteLine("\n Enter Teacher's Name");
                        name = Console.ReadLine();
                        Console.WriteLine("\n Enter Teacher's Class");
                        Class = Console.ReadLine();
                        Console.WriteLine("\n Enter Teacher's Section");
                        Section = Console.ReadLine();
                        teacherUtil.StoreTeacher(name, Class, Section);
                        break;

                    case 2:
                        Console.WriteLine("\n Enter Teacher's ID");
                        id = Console.ReadLine();
                        Console.WriteLine("\n Enter Teacher's Name");
                        name = Console.ReadLine();
                        Console.WriteLine("\n Enter Teacher's Class");
                        Class = Console.ReadLine();
                        Console.WriteLine("\n Enter Teacher's Section");
                        Section = Console.ReadLine();
                        teacherUtil.updateTeacher(id, name, Class, Section);
                        break;
                    case 3:
                        teacherUtil.PrintTeacherData();
                        break;
                    case 4:
                    default:
                        break;

                }
                teacherUtil.PrintTeacherData();
            }
        }

    }

}