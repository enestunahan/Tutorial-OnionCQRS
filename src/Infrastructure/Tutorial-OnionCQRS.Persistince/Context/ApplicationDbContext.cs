using Microsoft.EntityFrameworkCore;
using Tutorial_OnionCQRS.Domain.Entities;

namespace Tutorial_OnionCQRS.Persistince.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Pencil", Quantity = 100, Value = 10 },
                new Product() { Id = Guid.NewGuid(), Name = "Paper A4", Quantity = 100, Value = 1 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Quantity = 500, Value = 25 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
