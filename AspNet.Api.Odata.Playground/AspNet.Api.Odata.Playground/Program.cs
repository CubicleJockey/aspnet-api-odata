using AspNet.Api.Odata.Playground.Data.EF;
using AspNet.Api.Odata.Playground.DataGenerators;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace AspNet.Api.Odata.Playground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<DatabaseContext>();
                    _ = context.Database.EnsureCreated();

                    var dbContextOptions = services.GetRequiredService<DbContextOptions<DatabaseContext>>();
                    using var database = new DatabaseContext(dbContextOptions);

                    database.Products.AddRange(SeedData.GenerateProduct(40));

                    _ = database.SaveChanges();
                }
                catch (Exception exception)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(exception, "An error occurred seeding the DB.");
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
