using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Storage_System
{
    class TeacherStorage
    {
        string filePath = "C://Users/Disha_S/source/Phase1-DS-Algo/employee.txt";

        public void StoreData(Teacher teacher)
        {
            string content = JsonConvert.SerializeObject(teacher);
            File.AppendAllText(filePath, content + "\n");
        }

        public void WriteData(List<Teacher> teachersList)
        {
            List<string> content = new List<string>();

            foreach(Teacher teacher in teachersList)
            {
               content.Add( JsonConvert.SerializeObject(teachersList));
            }

            File.WriteAllLines(filePath, content);
        }

        public List<Teacher> RetrieveData()
        {
            List < Teacher >  teacher = new List<Teacher>();
            string[] contents = File.ReadAllLines(filePath);
            foreach (string employee in contents)
            {                
                Teacher temp =JsonConvert.DeserializeObject<Teacher>(employee);
                teacher.Add(temp);
            }
            return teacher;
        }

        public void updateTeacher(string ID, string name, string Class, string Section)
        {
            List<Teacher> teacherList = RetrieveData();
            int index = teacherList.FindIndex(x => x.ID == ID);
            if (index != 0)
            {
                teacherList.ElementAt(index).Name = name;
                teacherList.ElementAt(index).Class = Class;
                teacherList.ElementAt(index).Section = Section;
                WriteData(teacherList);
            }            
        }

        public void StoreTeacher(string name, string Class, string Section)
        {
            Teacher teacher = new Teacher(name, Class, Section);
            StoreData(teacher);
        }

        public void PrintTeacherData()
        {
            List<Teacher> teacherList = RetrieveData();
            foreach(Teacher teacher in teacherList)
            {
                teacher.print();
            }
        }
    }
}
