using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int SalePrice { get; set; }
        [Required]
        public int CostPrice { get; set; }
        public int DiscountPercent { get; set; }
    }
}
