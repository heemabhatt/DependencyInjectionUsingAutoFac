using Autofac;
using DI_Demo_BootCamp.Data.Interfaces;

namespace DI_Demo_BootCamp.Data.IoC
{
    public class IoCModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Core.IoC.IoCModule());

            builder.Register(c => new DI_Demo_BootCampWebContext("DI_Demo_BootCampWebContext")).InstancePerRequest();
            builder.RegisterType<CarsRepository>().As<ICarsRepository>().InstancePerLifetimeScope();
        }
    }
}
