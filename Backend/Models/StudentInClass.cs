using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class StudentInClass
    {
        [Key]
        public int Id { get; set; }
        public string? NameStudent { get; set; }

        [ForeignKey("Classes")]
        public int ClassId { get; set; }
        public virtual Classes? Classes { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
    }
}
