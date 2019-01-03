using Autofac;
using DI_Demo_BootCamp.Services.Interfaces;

namespace DI_Demo_BootCamp.Services.IoC
{
    public class IoCModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Data.IoC.IoCModule());

            builder.RegisterType<CarService>().As<ICarService>().InstancePerLifetimeScope();
        }
    }
}
