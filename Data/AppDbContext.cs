using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
namespace eCommerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_Order>().HasKey(e => new 
            {
                e.ProductId,
                e.OrderId
            });

            modelBuilder.Entity<Product_Order>().HasOne(m => m.Product).WithMany(e => e.Products_Orders).HasForeignKey(m => m.ProductId);
            modelBuilder.Entity<Product_Order>().HasOne(m => m.Order).WithMany(e => e.Products_Orders).HasForeignKey(m => m.OrderId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product_Order> Product_Orders { get; set; }
    }
}
