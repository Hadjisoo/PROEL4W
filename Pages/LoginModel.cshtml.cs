using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROEL4W.Models;

namespace PROEL4W.Pages
{
    public class LoginModelModel : PageModel
    {
        [BindProperty]
        public Users Users { get; set; } = new Users { Username = string.Empty, Password = string.Empty };

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
