using AccessoriesShop.Models;
using Microsoft.AspNetCore.Identity;

namespace AccessoriesShop.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            // Seed roles
            string[] roles = { "Admin", "User" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // Seed admin
            await SeedUserAsync(userManager,
                email: "admin@shophub.com",
                password: "Admin@123",
                firstName: "Admin",
                lastName: "ShopHub",
                role: "Admin");

            // Seed regular user
            await SeedUserAsync(userManager,
                email: "user@shophub.com",
                password: "User@123",
                firstName: "Regular",
                lastName: "User",
                role: "User");
        }

        private static async Task SeedUserAsync(
            UserManager<ApplicationUser> userManager,
            string email, string password,
            string firstName, string lastName, string role)
        {
            if (await userManager.FindByEmailAsync(email) != null)
                return;

            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(user, password);
            if (result.Succeeded)
                await userManager.AddToRoleAsync(user, role);
        }
    }
}
