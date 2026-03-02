using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MongoPlayground.Data.Dependencies;

namespace MongoPlayground.Console.ResolvedDependencies;

internal sealed class DbContextConfigurator : IDbContextConfigurator
{
    public void OnConfiguring(DbContextOptionsBuilder optionsBuilder, DatabaseFacade database)
    {
        System.Console.WriteLine("Qui configuro il dbContext");
        var connectionString = "mongodb://root:example@localhost:27017";
        var databaseName = "gigiPethot";
        optionsBuilder.UseMongoDB(connectionString, databaseName);

        database.AutoTransactionBehavior = AutoTransactionBehavior.Never;
    }
}
