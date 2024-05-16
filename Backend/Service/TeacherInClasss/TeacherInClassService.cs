using Backend.Data;
using Backend.Models;

namespace Backend.Service.TeacherInClasss
{
    public class TeacherInClassService : ITeacherInClassService
    {
        public readonly Thuchanh6DbContext _context;
        public TeacherInClassService(Thuchanh6DbContext context)
        {
            _context = context;
        }
        public bool AddTeacherInClass(TeacherInClass teacher)
        {
            _context.teacherInClasses.Add(teacher);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            TeacherInClass teacher = _context.teacherInClasses.Find(id);
            _context.teacherInClasses.Remove(teacher);
            _context.SaveChanges();
            return true;
        }

        public List<TeacherInClass> GetTeacherInClass()
        {
           return _context.teacherInClasses.OrderBy(x => x.Id).ToList();
        }

        public List<TeacherInClass> GetTeacherInClassById(int id)
        {
            return _context.teacherInClasses.Where(x => x.ClassId == id).OrderBy(x => x.Id).ToList();
        }

        public bool UpdateTeacherInClass(TeacherInClass teacher)
        {
            _context.teacherInClasses.Update(teacher);
            _context.SaveChanges();
            return true;
        }
    }
}
