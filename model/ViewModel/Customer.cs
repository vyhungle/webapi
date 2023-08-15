using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace model.ViewModel
{
    [Table("customer")]
    public class Customer
	{
        /// <summary>
        /// Mã Khách hàng
        /// </summary>
        [Key, Required]
        [Column("userid")]
        public long UserId { get; set; }
        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        [Required]
        [Column("username")]
        public string UserName { get; set; }
        /// <summary>
        /// Họ tên
        /// </summary>
        [Column("customername")]
        public string CustomerName { get; set; } = string.Empty;

	}
}

