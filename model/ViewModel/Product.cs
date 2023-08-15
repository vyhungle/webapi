using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Model
{
	[Table("product")]
	public class Product
	{
		/// <summary>
		/// Mã sản phẩm
		/// </summary>
		[Key, Required]
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Hình đại diện
        /// </summary>
        [Column("avatar")]
        public string Avatar { get; set; } = string.Empty;
        /// <summary>
        /// Giá cở sở
        /// </summary>
        [Column("sysprice")]
        public decimal SysPrice { get; set; }
        /// <summary>
        /// Giá bán
        /// </summary>
        [Column("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// Phần trăm giảm giá
        /// </summary>
        [Column("discount")]
        public double Discount { get; set; }

        [Column("discounta")]
        public double Discounta { get; set; }

    }
}

