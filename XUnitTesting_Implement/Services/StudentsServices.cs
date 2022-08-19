using XUnitTesting_Implement.Models;

namespace XUnitTesting_Implement.Services
{
    public class StudentsServices : IDataServices<Student>
    {
        private List<Student> _students { set; get; }
        public StudentsServices()
        {
            _students = new List<Student>()
            {
                new Student(){Id=1, Name ="sanjay", Class="BCA"}
            };
        }

        public bool AddEntity(Student data)
        {
            if(data == null)
            {
                return false;
            }
            else
            {
                _students.Add(data);
                return true;
            }
            
        }

        public bool DeleteEntity(int id)
        {
            var student = _students.FirstOrDefault(x => x.Id == id);
            if(student == null)
            {
                return false;
            }
            else
            {
                _students.Remove(student);
                return true;    
            }
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            var student= _students.Where(x => x.Id == id).FirstOrDefault();
            if(student== null)
            {
                throw new Exception("Data Not faound");
            }
            return student;
        }

        public bool UpdateEntity(Student data, int id)
        {
            var updateStudent= _students.FirstOrDefault(x => x.Id == id);
            if (updateStudent == null)
            {
                return false;

            }
            else
            {
                updateStudent.Id = id;
                updateStudent.Name=data.Name;
                updateStudent.Class=data.Class;
                return true;
            }
            
        }
    }
}
