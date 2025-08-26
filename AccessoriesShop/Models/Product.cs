using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessoriesShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }

        // Foreign Key for Category
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        // Navigation property: A product belongs to one category
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}