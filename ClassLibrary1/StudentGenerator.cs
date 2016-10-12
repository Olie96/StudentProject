using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breznjak_Student_project
{
    class StudentGenerator
    {
        private static StudentGenerator generator = null;
        private StudentGenerator() { }
        public static StudentGenerator GetStudentGeneratorInstance()
        {
            {
                if (generator == null)
                {
                    return new StudentGenerator();
                }
                return generator;
            }
        }
        int id = 1000;
        public int IDGenerator()
        {
            return id++;
        }
    }
}
