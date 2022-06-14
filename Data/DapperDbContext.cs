using dapper_core_lab.Models;
using Microsoft.EntityFrameworkCore;

namespace dapper_core_lab.Data
{
    public class DapperDbContext : DbContext
    {
        public DapperDbContext(DbContextOptions<DapperDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product[] {
                new Product() { Id = 1, Name = "餅乾", Price = 30m },
                new Product() { Id = 2, Name = "飲料", Price = 40m },
                new Product() { Id = 3, Name = "蛋糕", Price = 20m },
            });
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}