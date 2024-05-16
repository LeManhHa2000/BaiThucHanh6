using Backend.Models;

namespace Backend.Service.Teachers
{
    public interface ITeacherService
    {
        List<Teacher> GetTeacher();
        Boolean AddTeacher(Teacher teacher);
        Boolean UpdateTeacher(Teacher teacher);
        Boolean Delete(int id);
    }
}
