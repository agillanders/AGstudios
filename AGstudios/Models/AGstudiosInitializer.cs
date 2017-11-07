using AGstudios.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AGstudios.Models
{
    public class AGstudiosInitializer : MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>
    {
    }
}