using Microsoft.AspNetCore.Mvc;
using Qr_Menu.Models;

namespace Qr_Menu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Coffee", Price = 3.50m },
            new Product { Id = 2, Name = "Tea", Price = 2.50m },
            new Product { Id = 3, Name = "Cake", Price = 4.00m }
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Products.Select(p => p.Name);
        }
    }
}
