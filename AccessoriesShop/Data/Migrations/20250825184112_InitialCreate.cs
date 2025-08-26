using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccessoriesShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "85e4f8d3-d1cf-4778-b3cf-3d2d05a0d636", "Lana@LBR.com", true, false, null, "Lana@LBR.COM", "Lana@LBR.COM", "AQAAAAIAAYagAAAAEAYn9hI7h4eLhTMarhzyVY4E+Ku8pmMZATbsTXx2no85628rQIvRIBMUBF8LpmJk0w==", null, false, "", false, "Lana@LBR.com" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e576", 0, "9c481f47-83f1-4356-abd1-bb49c9e69e6d", "Balqees@LBR.COM", true, false, null, "Balqees@LBR.COM", "Balqees@LBR.COM", "AQAAAAIAAYagAAAAEK0+P8FcBDdLuXhyd/B/I0t0TW/VdnuKH34nemihCcn+ZEUCPbRFTsbcZNSUy2gtuw==", null, false, "", false, "Balqees@LBR.COM" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e577", 0, "02e72b98-1e34-44fa-a826-0378169c97bf", "Rawan@LBR.COM", true, false, null, "Rawan@LBR.COM", "Rawan@LBR.COM", "AQAAAAIAAYagAAAAELMQVEfTgS4Hm63OWC62Q9HzKG2tfjuwtYpoXDqVI0dM5ALz5HhV1/sCyRR/S6yzjA==", null, false, "", false, "Rawan@LBR.COM" }
                });

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
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 15, 21, 41, 11, 956, DateTimeKind.Local).AddTicks(7374), "a18be9c0-aa65-4af8-bd17-00bd9344e576" },
                    { 2, new DateTime(2025, 8, 20, 21, 41, 11, 956, DateTimeKind.Local).AddTicks(7408), "a18be9c0-aa65-4af8-bd17-00bd9344e577" }
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

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 49.99m, 1, 1 },
                    { 2, 1, 25.00m, 3, 2 },
                    { 3, 2, 299.50m, 5, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e577");

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
