using PROEL4W.Pages.Models;
using System.Collections.Generic;

namespace PROEL4W
{
    public class ApplicationDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
