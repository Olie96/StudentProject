using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breznjak_Student_project
{
    public class StudentContainer
    {
        public StudentContainer(){}
        StudentGenerator generator = StudentGenerator.GetStudentGeneratorInstance();
        protected List<Student> student = new List<Student>();   
        public void AddStudent(string name, string surname, float gpa)
        {
            student.Add(new Student(name, surname, gpa, generator.IDGenerator())); 
        }  // funkcija za unos studenata

        public IEnumerable<Student> GetOrderedStudents()    
        {
            return student.OrderBy(st => st.Surname);
        }
    }
}
