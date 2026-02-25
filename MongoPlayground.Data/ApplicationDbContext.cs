using Microsoft.EntityFrameworkCore;
using MongoPlayground.Data.Dependencies;
using MongoPlayground.Data.Entities;

namespace MongoPlayground.Data;

public sealed class ApplicationDbContext(IDbContextConfigurator dbContextConfigurator) : DbContext
{
    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        dbContextConfigurator.OnConfiguring(optionsBuilder);
    }
}