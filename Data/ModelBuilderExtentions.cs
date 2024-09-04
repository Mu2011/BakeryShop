using Microsoft.EntityFrameworkCore;
using BakeryShop.Models;

namespace BakeryShop.Data;

public static class ModelBuilderExtentions
{
  public static ModelBuilder Seed(this ModelBuilder modelbuilder)
  {
    Product[] products =
    [
      new() {
        ID = 1,
        Name = "Carrot Cake",
        Description = "Carrot Cake Any Description",
        Price = 15,
        IamgeName = "carrot_cake.webp"
      },
      new() {
        ID = 2,
        Name = "Lemo Tart",
        Description = "Lemo Tart Any Description",
        IamgeName = "lemo_tart.webp"
      },
      new() {
        ID = 4,
        Name = "Mutech Cake",
        Description = "Mutech Cake Any Description",
        Price = 50,
        IamgeName = "carrot_cake.webp"
      },
      new() {
        ID = 3,
        Name = "Cup Cake",
        Description = "Cup Cake Any Description",
        Price = 20,
        IamgeName = "cup_cake.webp"
      },
      new() {
        ID = 5,
        Name = "bread",
        Description = "bread Any Description",
        Price = 10,
        IamgeName = "bread.webp"
      },

    ];

    modelbuilder.Entity<Product>().HasData(products);
    return modelbuilder;
  }
}