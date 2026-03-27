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
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" },
                new Category { Id = 3, Name = "Home Goods" }
            );

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Wireless Earbuds", Description = "Compact wireless earbuds with clear sound and long battery life.", Price = 29.99m, CategoryId = 1, ImageUrl = "https://placehold.co/600x400/d4ede8/0d7377?text=Electronics" },
                new Product { Id = 2, Name = "USB-C Cable", Description = "Durable 2-meter USB-C charging and data cable.", Price = 9.99m, CategoryId = 1, ImageUrl = "https://placehold.co/600x400/d4ede8/0d7377?text=Electronics" },
                new Product { Id = 3, Name = "Classic T-Shirt", Description = "Comfortable cotton t-shirt available in multiple colors.", Price = 19.99m, CategoryId = 2, ImageUrl = "https://placehold.co/600x400/d4ede8/0d7377?text=Clothing" },
                new Product { Id = 4, Name = "Water Bottle", Description = "Stainless steel insulated bottle, keeps drinks cold for 24 hours.", Price = 14.99m, CategoryId = 3, ImageUrl = "https://placehold.co/600x400/d4ede8/0d7377?text=Home+Goods" },
                new Product { Id = 5, Name = "Notebook", Description = "A5 lined notebook, 200 pages, great for notes and journaling.", Price = 5.99m, CategoryId = 3, ImageUrl = "https://placehold.co/600x400/d4ede8/0d7377?text=Home+Goods" }
            );

        }
    }
}