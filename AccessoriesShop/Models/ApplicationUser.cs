using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AccessoriesShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; } // <-- تأكد من وجود علامة الاستفهام '?'

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; } // <-- تأكد من وجود علامة الاستفهام '?'
    }
}