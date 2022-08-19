using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTesting_Implement.Models;

namespace TestProjectStudents.TestData
{
    public class StudentDataTested
    {
        public static List<Student> GetAllDataTest()
        {
            return new List<Student>()
            {
                new Student(){Id=1, Name ="sanjay",Class="BCA"},
                //new Student(){Id=1, Name ="sanjay",Class="BCA"}
            };

        }
    }
}
