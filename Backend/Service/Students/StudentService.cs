using Backend.Data;
using Backend.Models;

namespace Backend.Service.Students
{
    public class StudentService : IStudentService
    {
        public readonly Thuchanh6DbContext _context;
        public StudentService(Thuchanh6DbContext context)
        {
            _context = context;
        }

        public bool AddStudent(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            Student student = _context.students.Find(id);
            _context.students.Remove(student);
            _context.SaveChanges();
            return true;
        }

        public List<Student> GetStudent()
        {
            return _context.students.ToList();
        }

        public bool UpdateStudent(Student student)
        {
            _context.students.Update(student);
            _context.SaveChanges();
            return true;
        }
    }
}
