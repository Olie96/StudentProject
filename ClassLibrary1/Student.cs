using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breznjak_Student_project
{
    public class Student : Person 
    {

        public float Gpa { get; set;}
        public Student(string name, string surname, float gpa, int id)
        {
            Name = name;
            Surname = surname;
            Gpa = gpa;
            Id = id;
        }
    }
}
