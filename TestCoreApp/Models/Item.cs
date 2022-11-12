using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestCoreApp.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        [DisplayName("The Price")]
        [Range(10, 1000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
    }
}
