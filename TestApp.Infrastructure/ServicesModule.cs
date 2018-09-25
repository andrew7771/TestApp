using Autofac;
using TestApp.Services.Abstract;
using TestApp.Services.Specific;

namespace TestApp.Infrastructure
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Greeter>()
                .As<IGreeter>()
                .InstancePerRequest();
            base.Load(builder);
        }
    }
}
