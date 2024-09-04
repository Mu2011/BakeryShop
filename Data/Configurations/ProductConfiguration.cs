using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakeryShop.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
  public void Configure(EntityTypeBuilder<Product> builder)
  {
    // Flurnt API
    builder.Property(p => p.IamgeName).HasColumnName("IamgeFileName");
  }
}