using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BakeryShop.Pages
{
    public class OrderSuccess(ILogger<OrderSuccess> logger) : PageModel
    {
        private readonly ILogger<OrderSuccess> _logger = logger;

        public void OnGet()
        {
        }
    }
}