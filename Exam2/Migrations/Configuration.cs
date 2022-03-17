namespace Exam2.Migrations
{
    using Exam2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exam2.Data.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exam2.Data.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Categories.AddOrUpdate(new Category {CategoryID = 2,CategoryName = "Quan ao", Description = "Quan ao mac tren nguoi", Picture = "https://cf.shopee.vn/file/ce03645345c4b23ecdf9e0de006931e5" }
                );
            context.Products.AddOrUpdate(new Product { ProductName = "quan ao tre em", QuantityPerUnit = 1, Discontinued = 1, ReorderLevel = 1, SupplierId = 1, UnitInStock = 10, UnitOnOrder = 5 , CategoryId = 2});
        }
    }
}
