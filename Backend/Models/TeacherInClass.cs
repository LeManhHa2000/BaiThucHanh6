using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class TeacherInClass
    {
        [Key]
        public int Id { get; set; }
        public string? NameTeacher { get; set; }

        [ForeignKey("Classes")]
        public int ClassId { get; set; }
        public virtual Classes? Classes { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
