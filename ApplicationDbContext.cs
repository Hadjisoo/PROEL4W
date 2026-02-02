using PROEL4W.Pages.Models;
using System.Collections.Generic;

namespace PROEL4W
{
    public class ApplicationDbContext
    {
        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Product> Products { get; set; }
    }
}
