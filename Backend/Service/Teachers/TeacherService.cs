using Backend.Data;
using Backend.Models;

namespace Backend.Service.Teachers
{
    public class TeacherService : ITeacherService
    {
        public readonly Thuchanh6DbContext _context;
        public TeacherService(Thuchanh6DbContext context)
        {
            _context = context;
        }
        public bool AddTeacher(Teacher teacher)
        {
            _context.teachers.Add(teacher);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            Teacher teacher = _context.teachers.Find(id);
            _context.teachers.Remove(teacher);
            _context.SaveChanges();
            return true;
        }

        public List<Teacher> GetTeacher()
        {
            return _context.teachers.ToList();
        }

        public bool UpdateTeacher(Teacher teacher)
        {
            _context.teachers.Update(teacher);
            _context.SaveChanges();
            return true;
        }
    }
}
