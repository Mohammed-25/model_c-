using Microsoft.AspNetCore.Mvc;
using ProductApplication.src.models;
using ProductApplication.src.services;

namespace ProductApplication.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class ProductsController : ControllerBase
    {
        private ProductService _productService;


        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]

        public IActionResult GetProductById(int id)
        {
            var products = _productService.GetProductById(id);
            return Ok(products);
        }
    
       [HttpGet("order-by-price")]

    public IActionResult GetProductsOrderedByPrice(){
        var products = _productService.GetProductsOrderedByPrice();
        return Ok(products);
    }


 }
}