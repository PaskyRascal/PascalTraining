
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Localization;
using System.Globalization;
using System.Threading;

namespace PascalTraining.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Add localization services
            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            await builder.Build().RunAsync();

            // Set the default culture
            var defaultCulture = new CultureInfo("en");
            CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
            CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

        }
    }
}
