using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Lets.Importation.Api
{
    public static class Program
    {
        public static void Main(string[] args) 
        {
            CreateHostBuilder(args)
                .ConfigureWebHost()
                .Build()
                .Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args);

        private static IHostBuilder ConfigureWebHost(this IHostBuilder builder) =>
            builder.ConfigureWebHostDefaults(CreateWebHost);

        private static void CreateWebHost(IWebHostBuilder builder) => builder.UseStartup<Startup>();

    }
}
