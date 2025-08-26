using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessoriesShop.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        // Foreign key for the User
        public string UserId { get; set; }

        // Navigation property to the user who made the order
        [ForeignKey("UserId")]
        public virtual IdentityUser? User { get; set; }

        // Navigation property: An order has multiple order items
        public virtual ICollection<OrderItem>? OrderItems { get; set; }
    }
}