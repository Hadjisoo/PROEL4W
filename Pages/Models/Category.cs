using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PROEL4W.Pages.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = string.Empty;

        [Range(1, 100)]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public bool IsActive { get; set; }

        [EmailAddress] // Example of an admin contact for the category
        public string? AdminContact { get; set; }
    }
}
