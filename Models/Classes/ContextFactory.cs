using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using travelproject.Models.Classes;
using System.IO;

public class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        // Proje kök dizinindeki appsettings.json’u oku
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<Context>();
        var connectionString = configuration.GetConnectionString("Context");
        optionsBuilder.UseSqlServer(connectionString);

        return new Context(optionsBuilder.Options);
    }
}
