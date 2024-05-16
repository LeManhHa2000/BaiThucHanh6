using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Backend.Data
{
    public class Thuchanh6DbContext : DbContext
    {
        public Thuchanh6DbContext(DbContextOptions<Thuchanh6DbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Classes> classes { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<TeacherInClass> teacherInClasses { get; set; }
        public DbSet<StudentInClass> studentInClasses { get; set; }
    }
}
