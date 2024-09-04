// using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryShop.Models;

public class Product
{
  public int ID { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; }
  // [Column("IamgeFileName")] => DataAnnotations
  public string IamgeName { get; set; }
}