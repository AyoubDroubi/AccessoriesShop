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
                    { 1, "Electronics" },
                    { 2, "Clothing" },
                    { 3, "Home Goods" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Compact wireless earbuds with clear sound and long battery life.", "https://placehold.co/600x400/d4ede8/0d7377?text=Electronics", "Wireless Earbuds", 29.99m },
                    { 2, 1, "Durable 2-meter USB-C charging and data cable.", "https://placehold.co/600x400/d4ede8/0d7377?text=Electronics", "USB-C Cable", 9.99m },
                    { 3, 2, "Comfortable cotton t-shirt available in multiple colors.", "https://placehold.co/600x400/d4ede8/0d7377?text=Clothing", "Classic T-Shirt", 19.99m },
                    { 4, 3, "Stainless steel insulated bottle, keeps drinks cold for 24 hours.", "https://placehold.co/600x400/d4ede8/0d7377?text=Home+Goods", "Water Bottle", 14.99m },
                    { 5, 3, "A5 lined notebook, 200 pages, great for notes and journaling.", "https://placehold.co/600x400/d4ede8/0d7377?text=Home+Goods", "Notebook", 5.99m }
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
