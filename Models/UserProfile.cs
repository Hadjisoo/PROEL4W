using System.ComponentModel.DataAnnotations;

namespace PROEL4W.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your full name")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required]
        [Range(18, 100, ErrorMessage = "You must be between 18 and 100 years old")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public required string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public required string ConfirmPassword { get; set; }
    }
}
