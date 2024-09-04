using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BakeryShop.Models;
using BakeryShop.Data;

namespace BakeryShop.Pages;

public class IndexModel(ILogger<IndexModel> logger, BakeryShopContext db) : PageModel
{
  private readonly ILogger<IndexModel> _logger = logger;
  private readonly BakeryShopContext _db = db;    

  public List<Product> Products { get; set; } = [];
  public Product FeaturedProduct { get; set; }
  public async Task OnGetAsync()
  {
    Products = await _db.Products.ToListAsync();
    // var randomIndex = new Random().Next(Products.Count);
    // FeaturedProduct = Products[randomIndex];
    FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
  }
}
