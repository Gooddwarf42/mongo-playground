using Microsoft.EntityFrameworkCore;

namespace MongoPlayground.Data.Dependencies;

public interface IDbContextConfigurator
{
    void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
}
