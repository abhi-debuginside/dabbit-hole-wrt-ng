using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace wRtaPi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            return new AutofacServiceProvider(ConfigureAutofac(services));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public IContainer ApplicationContainer { get; private set; }

        private IContainer ConfigureAutofac(IServiceCollection services)
        {
            var assembly = typeof(Startup).GetTypeInfo().Assembly;
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(assembly)
            .Where(t => t.Name.EndsWith("Repository")).AsSelf().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(assembly)
            .Where(t => t.Name.EndsWith("Service")).AsSelf().InstancePerLifetimeScope();
            builder.Populate(services);
            this.ApplicationContainer = builder.Build();
            return ApplicationContainer;
        }

    }
}
