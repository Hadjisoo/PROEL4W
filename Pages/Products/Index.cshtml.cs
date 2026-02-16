using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PROEL4W.Data;
using PROEL4W.Models;

namespace PROEL4W.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly PROEL4W.Data.PROEL4WContext _context;

        public IndexModel(PROEL4W.Data.PROEL4WContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Category).ToListAsync();
        }
    }
}
