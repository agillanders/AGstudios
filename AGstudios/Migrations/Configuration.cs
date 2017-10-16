namespace AGstudios.Migrations
{
    using AGstudios.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.People.AddOrUpdate(
              p => p.PersonID,
              new Person { FirstName = "Lynsey", Surname = "Gillanders", Town ="Woodbury" },
              new Person { FirstName = "Alec", Surname = "Gillanders", Town = "Woodbury" },
              new Person { FirstName = "Paul", Surname = "Peacey", Town = "Bridgwater" },
              new Person { FirstName = "Beverley", Surname = "Peacey", Town = "Bridgwater" },
              new Person { FirstName = "Barbara", Surname = "Brewer", Town = "Bridgwater" },
              new Person { FirstName = "Andrew", Surname = "Peacey", Town = "London" },
              new Person { FirstName = "Zoe", Surname = "Baker", Town = "Bridgwater" }
            );

        }
    }
}
