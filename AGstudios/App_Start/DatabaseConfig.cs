using AGstudios.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AGstudios.App_Start
{
    public class DatabaseConfig
    {
        public static void Configure()
        {
            Database.SetInitializer(new AGstudiosInitializer());
        }
    }
}