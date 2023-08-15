using System;
using business.services.Interface;
using Microsoft.EntityFrameworkCore;
using webapi.Context;
using webapi.Model;

namespace business.services
{
	public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;
  //      public ProductService(ApplicationDbContext dbContext)
		//{
		//	//_dbContext = dbContext;	
		//}
		public List<Product> GetProducts()
		{
		var product=	_dbContext.Products.ToList();
            return new List<Product>();
        }
	}
}

