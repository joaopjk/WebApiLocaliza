using Api.Service.Interface;
using Api.Service.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApi
{
    public class Startup
    {//
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Versionamento 
            services.AddApiVersioning(v =>
            {
                //Versão padrão da API
                v.DefaultApiVersion = new ApiVersion(1, 0);

                //Assume o default version caso não seja declarada nenhuma 
                v.AssumeDefaultVersionWhenUnspecified = true;

                // Exibe no header a versão da API
                v.ReportApiVersions = true;

                // Especifica que a versão será utilizada no header
                v.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
            }); 

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "Localiza Teste",
                        Version = "V1",
                        Description = "Decomposição de números"
                    });
            });

            #region Service
            services.AddScoped<IDecomporNumeroService, DecomporNumeroService>();
            #endregion
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "");
            });
        }
    }
}
