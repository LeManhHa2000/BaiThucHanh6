using Backend.Models;

namespace Backend.Service.Students
{
    public interface IStudentService
    {
        List<Student> GetStudent();
        Boolean AddStudent(Student student);
        Boolean UpdateStudent(Student student);
        Boolean Delete(int id);
    }
}
