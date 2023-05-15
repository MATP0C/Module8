using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace FinalTask
{
    class Program
    {
        public static void Main()
        {
            String FilePath = "C:\\Users\\bogda\\OneDrive\\Рабочий стол\\Students.dat";
            List<Student> people = new List<Student>();
            if (File.Exists(FilePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(FilePath, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        string group = reader.ReadString();
                        string dateOfBirth = reader.ReadString();
                        people.Add(new Student(name, group, dateOfBirth));
                    }
                }
                foreach (Student person in people)
                {
                    Console.WriteLine("Из файла считано");
                    Console.WriteLine("Имя: {0}, Группа: {1}, Дата рождения: {2}", person.Name, person.Group, person.DateOfBirth);
                }
            }
        }

    }
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string DateOfBirth { get; set; }
        public Student(string name, string group, string dateOfBirth)
        {
            Name = name;
            Group = group;
            DateOfBirth = dateOfBirth;
        }

    }
}