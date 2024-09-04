using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using BakeryShop.Models;
using BakeryShop.Data;
using System.Net.Mail;
using System.Net;



namespace BakeryShop.Pages;

public class orderModel(BakeryShopContext db) : PageModel
{
  private readonly BakeryShopContext _db = db;
  [BindProperty(SupportsGet = true)]
  public int Id { get; set; }
  public Product product { get; set; }
  [BindProperty, EmailAddress, Required(ErrorMessage = "Please enter a valid email."), Display(Name = "Your Email Address")]
  public string OrderEmail { get; set; }
  [BindProperty, Required(ErrorMessage = "Please supply a shipping address."), Display(Name = "Shipping Address")]
  public string OrderShopping { get; set; }
  [BindProperty, Display(Name = "Quantity")]
  public int OrderQuantity { get; set; }

  public async Task OnGetAsync() => product = await _db.Products.FindAsync(Id);
  // public async Task<IActionResult> OnPostAsync()
  // {
  //   product = await _db.Products.FindAsync(Id);
  //   if (ModelState.IsValid)
  //   {
  //     var body = $"<p>Thank you, We received your order for {OrderQuantity} of pieces of {product.Name}.</p>" +
  //     $"<p>Your Address is: {OrderShopping}.</p>" +
  //     $"<p>Your total price is: {OrderQuantity * product.Price}.</p>" +
  //     $"<p><b>Your order will delivered without 60 Minutes.</b></p>";
  //     using var smtp = new SmtpClient("smtp.gmail.com", 587)
  //     {
  //       Credentials = new NetworkCredential("lolkar471@gmail.com", "Mutech"),
  //       EnableSsl = true
  //     };
  //     smtp.Host = "smtp.gmail.com";
  //     smtp.Port = 587;
  //     smtp.EnableSsl = true;
  //     var message = new MailMessage
  //     {
  //       From = new MailAddress("lolkar471@gmail.com"),
  //       Subject = "Mutech Coffee - New Order",
  //       Body = body,
  //       IsBodyHtml = true
  //     };
  //     message.To.Add(OrderEmail);
  //     await smtp.SendMailAsync(message);

  //     return RedirectToPage("OrderSuccess");
  //   }
  //   return Page();

  // }

  public async Task<IActionResult> OnPostAsync()
  {
    product = await _db.Products.FindAsync(Id);
    if (ModelState.IsValid)
    {
      var body = $"<p>Thank you, We received your order for {OrderQuantity} pieces of {product.Name}.</p>" +
                $"<p>Your Address is: {OrderShopping}.</p>" +
                $"<p>Your total price is: {OrderQuantity * product.Price}.</p>" +
                $"<p><b>Your order will be delivered within 60 minutes.</b></p>";

      var message = new MailMessage
      {
        From = new MailAddress("lolkar471@gmail.com"),
        Subject = "Mutech Coffee - New Order",
        Body = body,
        IsBodyHtml = true
      };
      message.To.Add(OrderEmail);

      using var smtp = new SmtpClient("smtp.gmail.com", 587)
      {
        Credentials = new NetworkCredential("lolkar471@gmail.com", "Mutech"), // استخدم كلمة مرور التطبيق هنا
        EnableSsl = true
      };

      try
      {
        await smtp.SendMailAsync(message);
      }
      catch (SmtpException ex)
      {
        Console.WriteLine($"SMTP Error: {ex.Message}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
      }

      return RedirectToPage("OrderSuccess");
    }
    return Page();
  }



  // public async Task<IActionResult> OnPostAsync()
  // {
  //   product = await _db.Products.FindAsync(Id);

  //   if (ModelState.IsValid)
  //   {
  //     var body = $"<p>Thank you, We received your order for {OrderQuantity} pieces of {product.Name}.</p>" +
  //               $"<p>Your Address is: {OrderShopping}.</p>" +
  //               $"<p>Your total price is: {OrderQuantity * product.Price}.</p>" +
  //               $"<p><b>Your order will be delivered within 60 Minutes.</b></p>";

  //     var message = new MimeMessage();
  //     message.From.Add(new MailboxAddress("Mutech Coffee", "lolkar471@gmail.com"));
  //     message.To.Add(new MailboxAddress("", OrderEmail));
  //     message.Subject = "Mutech Coffee - New Order";

  //     var bodyBuilder = new BodyBuilder
  //     {
  //       HtmlBody = body
  //     };
  //     message.Body = bodyBuilder.ToMessageBody();

  //     using var client = new SmtpClient();
  //     try
  //     {
  //       await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
  //       await client.AuthenticateAsync("lolkar471@gmail.com", "Mutech");
  //       await client.SendAsync(message);
  //     }
  //     catch (SmtpCommandException ex)
  //     {
  //       Console.WriteLine($"Error sending email: {ex.StatusCode} - {ex.Message}");
  //     }
  //     catch (SmtpProtocolException ex)
  //     {
  //       Console.WriteLine($"Protocol error: {ex.Message}");
  //     }
  //     catch (Exception ex)
  //     {
  //       Console.WriteLine($"Unexpected error: {ex.Message}");
  //     }
  //     finally
  //     {
  //       await client.DisconnectAsync(true);
  //     }
  //     return RedirectToPage("OrderSuccess");
  //   }

  //   return Page();
  // }

}