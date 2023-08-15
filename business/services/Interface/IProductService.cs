using System;
using webapi.Model;

namespace business.services.Interface
{
	public interface IProductService
	{
        List<Product> GetProducts();
    }
}

