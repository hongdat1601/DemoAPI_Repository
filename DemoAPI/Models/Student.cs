using System.ComponentModel.DataAnnotations;

namespace DemoAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string? Name { get; set; }

        [Required]
        public int Old { get; set; }
    }
}
