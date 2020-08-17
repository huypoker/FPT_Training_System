using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FPT_Training_System.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Cpurse Name")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}