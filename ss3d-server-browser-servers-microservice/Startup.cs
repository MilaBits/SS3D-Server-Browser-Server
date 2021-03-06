using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ss3d_server_browser_servers_microservice.Data;
using ss3d_server_browser_servers_microservice.Messaging;

namespace ss3d_server_browser_servers_microservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            CurrentConfiguration = Configuration;
        }

        public IConfiguration Configuration { get; }
        public static IConfiguration CurrentConfiguration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<GameServerDataContext>(options => options.UseMySql(
                Configuration.GetConnectionString("ServersDatabase"),
                sqlOptions => { sqlOptions.EnableRetryOnFailure(); }));
            
            services.AddHostedService<RabbitRpc>();

            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}