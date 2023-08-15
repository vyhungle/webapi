using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace model.ViewModel
{
    [Table("test")]
    public class Test
	{
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Hình đại diện
        /// </summary>
        public string Avatar { get; set; } = string.Empty;
        /// <summary>
        /// Giá cở sở
        /// </summary>
        public decimal SysPrice { get; set; }
    }
}

