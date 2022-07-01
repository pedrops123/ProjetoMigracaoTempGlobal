using Lets.Core.Api.Startup.DefaultApi;
using Lets.Core.Api.Startup.Extensions;
using Lets.Importation.Domain.Command.Commands.TesteImportacao.Create;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lets.Importation.Api
{
    public class Startup : AbstractStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        { }
        
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services
                .AddMediatR<CreateTesteImportacaoCommandHandle>();
            //.AddClients(Configuration)
            //.AddServices();
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            base.Configure(app, env);
        }
    }
}
