using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROEL4W.Models;

namespace PROEL4W.Data
{
    public class PROEL4WContext : DbContext
    {
        public PROEL4WContext (DbContextOptions<PROEL4WContext> options)
            : base(options)
        {
        }

        public DbSet<PROEL4W.Models.Category> Category { get; set; } = default!;
        public DbSet<PROEL4W.Models.Product> Product { get; set; } = default!;
        public DbSet<PROEL4W.Models.Users> Users { get; set; } = default!;
    }
}
