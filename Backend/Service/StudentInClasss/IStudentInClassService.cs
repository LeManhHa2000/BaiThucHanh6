using Backend.Models;

namespace Backend.Service.StudentInClasss
{
    public interface IStudentInClassService
    {
        List<StudentInClass> GetStudentInClass();
        List<StudentInClass> GetStudentInClassById(int id);
        Boolean AddStudentInClass(StudentInClass student);
        Boolean UpdateStudentInClass(StudentInClass student);
        Boolean Delete(int id);
    }
}
