using Microsoft.AspNetCore.Mvc;
using Shopping.API.Models;
using Shopping.Client.Data;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        public readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            //var rn = new Random();
            //return Enumerable.Range(1, 5).Select(Index => new Product
            //{
            //    Name = "asd"
            //}).ToArray();
            return ProductContext.Products;
        }
    }
}
