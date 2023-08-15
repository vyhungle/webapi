using System;
using business.services.Interface;
using Microsoft.AspNetCore.Mvc;

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
        public int GetProduct()
        {
            var product = _productService.GetProducts();
            return 0;
        }
    }

}

