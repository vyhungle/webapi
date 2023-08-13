using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Model
{
	[Table("product")]
	public class Product
	{
		[Key, Required]
		public int Id { get; set; }

		public string Name { get; set; }
	}
}

