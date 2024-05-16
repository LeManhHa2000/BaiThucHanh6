using Backend.Data;
using Backend.Models;

namespace Backend.Service.Classs
{
    public class ClassService : IClassService
    {
        public readonly Thuchanh6DbContext _thuchanh6DbContext;
        public ClassService(Thuchanh6DbContext thuchanh6DbContext)
        {
            _thuchanh6DbContext = thuchanh6DbContext;
        }

        public bool AddClass(Classes classes)
        {
            _thuchanh6DbContext.classes.Add(classes);
            _thuchanh6DbContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            Classes classes = _thuchanh6DbContext.classes.Find(id);
            _thuchanh6DbContext.classes.Remove(classes);
            _thuchanh6DbContext.SaveChanges();
            return true;
        }

        public Classes GetbyId(int id)
        {
            return _thuchanh6DbContext.classes.Find(id);
        }

        public List<Classes> GetClasses()
        {
            return _thuchanh6DbContext.classes.OrderBy(x => x.Id).ToList();
        }

        public bool UpdateClass(Classes classes)
        {
            _thuchanh6DbContext.classes.Update(classes);
            _thuchanh6DbContext.SaveChanges();
            return true;
        }
    }
}
