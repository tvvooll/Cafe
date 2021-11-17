using Microsoft.EntityFrameworkCore;
using System;

namespace CafeLab.Models
{
    public class CafeDbContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDishes> OrderDishes { get; set; }

        public CafeDbContext()
            : base()
        {
            Database.EnsureCreated();
        }

        public CafeDbContext(DbContextOptions<CafeDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("host=ec2-52-19-164-214.eu-west-1.compute.amazonaws.com;port=5432;database=d5l0o8lk13nv7d;username=hbqcvaqjzqjkff;password=b3c88f2a758a775ff7871928972c5e65235d7178a6da4604756176a2a10df12e;pooling=True;trust server certificate=True;ssl mode=Require");
            }
        }
    }
}
