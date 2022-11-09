using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Canteen_Management_System.Models
{

    public class AppDbContext : DbContext

    /*public class AppDbContext : DbContext*/

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne<Customer>().WithOne().OnDelete(DeleteBehavior.ClientSetNull)
        }*/


        public DbSet<cart> Carts { get; set; }

    }
}
