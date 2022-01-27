using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Product.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<User> VerifyAccount { get; set; }
        public DbSet<ProductM> tbl_Products { get; set; }
        public DbSet<Category> tbl_Category { get; set; }

    }
}
