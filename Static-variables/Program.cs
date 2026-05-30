using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_variables
{
    class Student
    {
        int id;
        string name; 
        public static string school = "Bhashyam";

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Desplay()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("School: " + school);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(22,"John");
            s1.Desplay();
            Console.WriteLine("========================");
            Student.school = "BIIT";
            s1.Desplay();
            
        }
    }
}
