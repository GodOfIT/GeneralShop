using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;
using GeneralShop.Data.Infrastructure;
using System.Reflection;
using GeneralShop.Data;
using GeneralShop.Data.Respositories;
using System.Web.Mvc;
using System.Web.Http;
using GeneralShop.Service;
using Autofac.Integration.WebApi;

[assembly: OwinStartup(typeof(GeneralShop.Web.App_Start.Startup))]

namespace GeneralShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutoFac(app);
        }

        public void ConfigAutoFac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterType<ShopDbContext>().AsSelf().InstancePerRequest();

            // Repositories
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
               .Where(t => t.Name.EndsWith("Repository"))
               .AsImplementedInterfaces().InstancePerRequest();
            //Services
            builder.RegisterAssemblyTypes(typeof(IPostCategoryService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);

        }
    }
}

