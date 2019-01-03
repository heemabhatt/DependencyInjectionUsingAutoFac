using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;

namespace DI_Demo_BootCamp.Web.IoC
{
    public class IoCModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Services.IoC.IoCModule());

            builder.RegisterControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterFilterProvider();
            builder.RegisterSource(new ViewRegistrationSource());
        }
    }
}
