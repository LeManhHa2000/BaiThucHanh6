using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
