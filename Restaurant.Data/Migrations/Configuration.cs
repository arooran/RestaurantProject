namespace Restaurant.Data.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestaurantDbContext context)
        {

            context.PhoneNumberTypes.AddOrUpdate(p => p.Description,
                new PhoneNumberTypes { Description = "Office", CreatedBy = "Arooran", CreatedDate = DateTime.Now, IP = "0.0.0.0" },
                new PhoneNumberTypes { Description = "Fax", CreatedBy = "Arooran", CreatedDate = DateTime.Now, IP = "0.0.0.0" });
            

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
        }
    }
}
