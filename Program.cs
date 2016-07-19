using System.IO;
using Microsoft.AspNetCore.Hosting;
using HelloCore.Api;

namespace HelloCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel() // Since we are on Mac OS, we are using kestrel
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>() // Use our Startup class in /App/
                .Build();
            host.Run(); // Actually run the app
        }
    }
}