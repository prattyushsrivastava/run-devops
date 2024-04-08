using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Models;
using Shopping.Client.Data;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        public readonly ILogger<ProductController> _logger;
        private readonly ProductContext _productContext;
        public ProductController(ILogger<ProductController> logger , ProductContext productContext)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger)); 
        }

      

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
           
            return await _productContext.Products.Find(p => true).ToListAsync();
        }
    }
}
