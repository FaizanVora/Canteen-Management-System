using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Canteen_Management_System.Models
{

    public class AppDbContext : DbContext

    /*public class AppDbContext : DbContext*/

    {
#pragma warning disable CS8618 // Non-nullable property 'Orders' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'carts' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Customers' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable property 'Customers' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning restore CS8618 // Non-nullable property 'carts' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning restore CS8618 // Non-nullable property 'Orders' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<cart> carts { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne<Customer>().WithOne().OnDelete(DeleteBehavior.ClientSetNull)
        }*/




    }
}
