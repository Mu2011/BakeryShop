using BakeryShop.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using BakeryShop.Models;

namespace BakeryShop.Data;

public class BakeryShopContext : DbContext
{
  public DbSet<Product> Products { get; set; }
  
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    // base.OnConfiguring(optionsBuilder);
    // Configure DBContext to use SQLite
    optionsBuilder.UseSqlite(@"Data Source=BakeryDB.db");
  }
  protected override void OnModelCreating(ModelBuilder modelbuilder)
  {
    // base.OnModelCreating(modelbuilder);

    // Apply configuration in ProductConfigurations --> Migrate
    modelbuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
  }
} 