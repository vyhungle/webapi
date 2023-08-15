using System;
using business.services.Interface;
using Microsoft.AspNetCore.Mvc;
using webapi.Model;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class ProductController
    {
        private readonly IProductService _productService;
        public ProductController(
            IProductService productService
        )
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> GetProduct()
        {
            return _productService.GetProducts();
        }
    }

}

