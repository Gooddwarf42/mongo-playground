using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MongoPlayground.Data.Dependencies;

public interface IDbContextConfigurator
{
    void OnConfiguring(DbContextOptionsBuilder optionsBuilder, DatabaseFacade database);
}
