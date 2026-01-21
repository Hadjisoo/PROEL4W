using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROEL4W.Pages.Profile;

namespace PROEL4W.Pages
{
    public class LoginModelModel : PageModel
    {
        [BindProperty]
        public Users Users { get; set; } = new Users();

        public IActionResult OnPost()
        {
            if (Users.Username == "Admin" && Users.Password == "Admin123")
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
