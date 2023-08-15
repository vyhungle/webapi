using System;
using business.DB;
using business.services.Interface;
using Microsoft.EntityFrameworkCore;
using webapi.Context;
using webapi.Model;

namespace business.services
{
	public class ProductService : IProductService
    {
        private readonly ProductDB _productDB;
        public ProductService(ApplicationDbContext context)
        {
            _productDB = new ProductDB(context);
        }

        public List<Product> GetProducts()
		{
		    return _productDB.GetProducts();
        }
	}
}

