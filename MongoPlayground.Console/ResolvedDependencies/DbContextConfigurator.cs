using Microsoft.EntityFrameworkCore;
using MongoPlayground.Data.Dependencies;

namespace MongoPlayground.Console.ResolvedDependencies;

internal sealed class DbContextConfigurator : IDbContextConfigurator
{
    public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        System.Console.WriteLine("Qui configuro il dbContext");
        var connectionString = "mongodb://root:example@localhost:27017";
        var database = "gigiPethot";
        optionsBuilder.UseMongoDB(connectionString, database);
    }
}
