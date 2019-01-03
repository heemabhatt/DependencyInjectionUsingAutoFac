using DI_Demo_BootCamp.Core.Models;
using System.Data.Entity.Migrations;

namespace DI_Demo_BootCamp.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DI_Demo_BootCamp.Data.DI_Demo_BootCampWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DI_Demo_BootCamp.Data.DI_Demo_BootCampWebContext context)
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

            context.Cars.AddOrUpdate(
                c=>c.Id,new Car { Name="Honda" });
        }
    }
}
