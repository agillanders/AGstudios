using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AGstudios.Models;
using System.Data.Entity.Migrations;

namespace AGstudios.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "AGstudios.Models.IdentityModels";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
        }
    }
}