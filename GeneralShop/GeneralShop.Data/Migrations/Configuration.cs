namespace GeneralShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GeneralShop.Data.ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GeneralShop.Data.ShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopDbContext()));
            var user = new ApplicationUser()
            {
                UserName = "Min",
                Email = "minmin@gmail.com",
                EmailConfirmed = true,
                Birthday = DateTime.Now,
                FullName = "Min min"

            };
            manager.Create(user, "123456");
            if(!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manager.FindByEmail("minmin@gmail.com");
            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
