using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROEL4W.Pages.Profile;

namespace PROEL4W.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public UserProfile User { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            // This checks all [Required], [Range], [Compare], etc.
            if (!ModelState.IsValid)
            {
                // If rules are broken, return to the page to show errors
                return Page();
            }

            // If valid, save to database...
            return RedirectToPage("Success");
        }
    }
}
