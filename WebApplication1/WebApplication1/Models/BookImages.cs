using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class BookImages
    {
        public int Id { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public int BookId { get; set; }
      
    }
}
