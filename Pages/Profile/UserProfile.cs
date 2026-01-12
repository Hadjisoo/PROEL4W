using System.ComponentModel.DataAnnotations;

namespace PROEL4W.Pages.Profile
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your full name")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(18, 100, ErrorMessage = "You must be between 18 and 100 years old")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
