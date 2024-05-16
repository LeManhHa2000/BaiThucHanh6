using Backend.Models;

namespace Backend.Service.TeacherInClasss
{
    public interface ITeacherInClassService
    {
        List<TeacherInClass> GetTeacherInClass();
        List<TeacherInClass> GetTeacherInClassById(int id);
        Boolean AddTeacherInClass(TeacherInClass teacher);
        Boolean UpdateTeacherInClass(TeacherInClass teacher);
        Boolean Delete(int id);
    }
}
