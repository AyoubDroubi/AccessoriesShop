using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccessoriesShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Necklaces" },
                    { 2, "Bracelets" },
                    { 3, "Rings" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A beautiful silver necklace with a heart pendant.", "https://placehold.co/600x400/EEE/31343C?text=Necklace", "Silver Heart Necklace", 49.99m },
                    { 2, 1, "Elegant 18k gold plated chain.", "https://placehold.co/600x400/EEE/31343C?text=Necklace", "Gold Chain Necklace", 79.99m },
                    { 3, 2, "Stylish genuine leather bracelet for everyday wear.", "https://placehold.co/600x400/EEE/31343C?text=Bracelet", "Leather Bracelet", 25.00m },
                    { 4, 2, "Handmade bracelet with colorful beads.", "https://placehold.co/600x400/EEE/31343C?text=Bracelet", "Beaded Bracelet", 15.50m },
                    { 5, 3, "A stunning diamond ring, perfect for special occasions.", "https://placehold.co/600x400/EEE/31343C?text=Ring", "Diamond Ring", 299.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
