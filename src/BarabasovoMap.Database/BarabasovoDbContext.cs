using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BarabasovoMap.Database.Models;
using BarabasovoMap.Database.Configurations;

namespace BarabasovoMap.Database
{
    public class BarabasovoDbContext : DbContext
    {
        public BarabasovoDbContext(DbContextOptions<BarabasovoDbContext> options)
            : base(options)
        {

        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Point> Points { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new OwnerConfiguration());
            modelBuilder.ApplyConfiguration(new PointConfiguration());
            modelBuilder.ApplyConfiguration(new PropertyConfiguration());
            modelBuilder.ApplyConfiguration(new SellerConfiguration());
        }
    }
}