using System.ComponentModel.DataAnnotations;

namespace AccessoriesShop.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}