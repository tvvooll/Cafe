using Microsoft.EntityFrameworkCore;

namespace CafeLab.Models
{
    public class CafeDbContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public CafeDbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
