using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PROEL4W.Data;
using PROEL4W.Models;

namespace PROEL4W.Pages.Usersss
{
    public class DetailsModel : PageModel
    {
        private readonly PROEL4W.Data.PROEL4WContext _context;

        public DetailsModel(PROEL4W.Data.PROEL4WContext context)
        {
            _context = context;
        }

        public Users Users { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (users is not null)
            {
                Users = users;

                return Page();
            }

            return NotFound();
        }
    }
}
