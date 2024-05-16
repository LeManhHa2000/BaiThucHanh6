using Backend.Models;

namespace Backend.Service.Classs
{
    public interface IClassService
    {
        List<Classes> GetClasses();
        Boolean AddClass(Classes classes);
        Boolean UpdateClass(Classes classes);
        Boolean Delete(int id);
        Classes GetbyId(int id);
    }
}
