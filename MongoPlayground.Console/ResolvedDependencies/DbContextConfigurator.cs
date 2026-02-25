using Microsoft.EntityFrameworkCore;
using MongoPlayground.Data.Dependencies;

namespace MongoPlayground.Console.ResolvedDependencies;

internal sealed class DbContextConfigurator : IDbContextConfigurator
{
    public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        System.Console.WriteLine("Qui configuro il dbContext");
        throw new NotImplementedException();
    }
}
