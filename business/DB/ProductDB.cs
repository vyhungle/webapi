using System;
using webapi.Context;
using webapi.Model;

namespace business.DB
{
	public class ProductDB
	{
		private ApplicationDbContext _context;
		public ProductDB(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<Product> GetProducts()
		{
			return _context.Products.ToList();
		}
	}
}

