using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace ConsoleApp3
{
    internal class Program
    {
        static Task Main(string[] args) =>
    CreateHostBuilder(args).Build().RunAsync();

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(options =>
            {
                options.AddJsonFile("appsettings.json");
            })
            .ConfigureServices(services =>
            {
                services.AddHostedService<Worker>();
            });

    }
}