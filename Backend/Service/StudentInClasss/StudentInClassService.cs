using Backend.Data;
using Backend.Models;

namespace Backend.Service.StudentInClasss
{
    public class StudentInClassService : IStudentInClassService
    {
        public readonly Thuchanh6DbContext _context;
        public StudentInClassService(Thuchanh6DbContext context)
        {
            _context = context;
        }
        public bool AddStudentInClass(StudentInClass student)
        {
            _context.studentInClasses.Add(student);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            StudentInClass studentInClass = _context.studentInClasses.Find(id);
            _context.studentInClasses.Remove(studentInClass);
            _context.SaveChanges();
            return true;
        }

        public List<StudentInClass> GetStudentInClass()
        {
            return _context.studentInClasses.OrderBy(x => x.Id).ToList();
        }

        public List<StudentInClass> GetStudentInClassById(int id)
        {
            return _context.studentInClasses.Where(x => x.ClassId == id).OrderBy(x => x.Id).ToList();
        }

        public bool UpdateStudentInClass(StudentInClass student)
        {
            _context.studentInClasses.Update(student);
            _context.SaveChanges();
            return true;
        }
    }
}
