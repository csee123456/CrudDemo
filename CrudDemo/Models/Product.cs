using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    public class Product
    {
        public int Id { get; set; } // 主鍵 (Primary Key)

        [Display(Name = "商品名稱")]
        [Required(ErrorMessage = "請輸入商品名稱")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "分類")]
        public string Category { get; set; } = string.Empty;

        [Display(Name = "價格")]
        [Range(0, 1000000, ErrorMessage = "價格不可小於 0")]
        public decimal Price { get; set; }

        [Display(Name = "庫存數量")]
        public int Stock { get; set; }

        [Display(Name = "建檔日期")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}