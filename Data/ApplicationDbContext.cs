using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<TypesOfDevice> TypesOfDevice { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}
