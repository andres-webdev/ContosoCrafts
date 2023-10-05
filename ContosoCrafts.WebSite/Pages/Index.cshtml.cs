using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
<<<<<<< HEAD
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }  
=======

        public JsonFileProductService ProductService;

        public IEnumerable<Product> Products { get; private set; }

>>>>>>> 2a5f4c08b5e86072ba700fc84f4cf725919eba53
        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}