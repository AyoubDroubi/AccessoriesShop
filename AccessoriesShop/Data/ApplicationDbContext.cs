using AccessoriesShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccessoriesShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Necklaces" },
                new Category { Id = 2, Name = "Bracelets" },
                new Category { Id = 3, Name = "Rings" }
            );

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Silver Heart Necklace", Description = "A beautiful silver necklace with a heart pendant.", Price = 49.99m, CategoryId = 1, ImageUrl = "https://placehold.co/600x400/EEE/31343C?text=Necklace" },
                new Product { Id = 2, Name = "Gold Chain Necklace", Description = "Elegant 18k gold plated chain.", Price = 79.99m, CategoryId = 1, ImageUrl = "https://placehold.co/600x400/EEE/31343C?text=Necklace" },
                new Product { Id = 3, Name = "Leather Bracelet", Description = "Stylish genuine leather bracelet for everyday wear.", Price = 25.00m, CategoryId = 2, ImageUrl = "https://placehold.co/600x400/EEE/31343C?text=Bracelet" },
                new Product { Id = 4, Name = "Beaded Bracelet", Description = "Handmade bracelet with colorful beads.", Price = 15.50m, CategoryId = 2, ImageUrl = "https://placehold.co/600x400/EEE/31343C?text=Bracelet" },
                new Product { Id = 5, Name = "Diamond Ring", Description = "A stunning diamond ring, perfect for special occasions.", Price = 299.50m, CategoryId = 3, ImageUrl = "https://placehold.co/600x400/EEE/31343C?text=Ring" }
            );

        }
    }
}