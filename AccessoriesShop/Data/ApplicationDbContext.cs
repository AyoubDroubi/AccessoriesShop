using AccessoriesShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccessoriesShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // --- Seeding for 3 Users (from previous step) ---
            var hasher = new PasswordHasher<IdentityUser>();
            const string USER_ID_1 = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string USER_ID_2 = "a18be9c0-aa65-4af8-bd17-00bd9344e576";
            const string USER_ID_3 = "a18be9c0-aa65-4af8-bd17-00bd9344e577";

            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = USER_ID_1,
                    UserName = "Lana@LBR.com",
                    NormalizedUserName = "Lana@LBR.COM",
                    Email = "Lana@LBR.com",
                    NormalizedEmail = "Lana@LBR.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    SecurityStamp = string.Empty
                },
                new IdentityUser
                {
                    Id = USER_ID_2,
                    UserName = "Balqees@LBR.COM",
                    NormalizedUserName = "Balqees@LBR.COM",
                    Email = "Balqees@LBR.COM",
                    NormalizedEmail = "Balqees@LBR.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    SecurityStamp = string.Empty
                },
                new IdentityUser
                {
                    Id = USER_ID_3,
                    UserName = "Rawan@LBR.COM",
                    NormalizedUserName = "Rawan@LBR.COM",
                    Email = "Rawan@LBR.COM",
                    NormalizedEmail = "Rawan@LBR.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    SecurityStamp = string.Empty
                }
            );

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

            builder.Entity<Order>().HasData(
                new Order { Id = 1, UserId = USER_ID_2, OrderDate = DateTime.Now.AddDays(-10) },
                new Order { Id = 2, UserId = USER_ID_3, OrderDate = DateTime.Now.AddDays(-5) }
            );

            builder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1, Price = 49.99m }, // Silver Heart Necklace
                new OrderItem { Id = 2, OrderId = 1, ProductId = 3, Quantity = 2, Price = 25.00m }, // 2x Leather Bracelet
                new OrderItem { Id = 3, OrderId = 2, ProductId = 5, Quantity = 1, Price = 299.50m } // Diamond Ring
            );
        }
    }
}