using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1, 10000, ErrorMessage = "Display Order must be between 1 and 10000")]
        public int DisplayOrder { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
