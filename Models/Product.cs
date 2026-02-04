using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROEL4W.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required, Range(0.01, 10000)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required, Display(Name = "Stock Quantity")]
        public int StockQuantity { get; set; }

        public string SKU { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}
