using System.Data.Entity;

namespace DI_Demo_BootCamp.Data
{
    public class DI_Demo_BootCampWebContext : DbContext
    {
        public DI_Demo_BootCampWebContext() : base("name=DI_Demo_BootCampWebContext")
        {
        }

        public DI_Demo_BootCampWebContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public System.Data.Entity.DbSet<DI_Demo_BootCamp.Core.Models.Car> Cars { get; set; }
    }
}
