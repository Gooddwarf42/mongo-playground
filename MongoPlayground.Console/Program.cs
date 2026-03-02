// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using MongoPlayground.Console.ResolvedDependencies;
using MongoPlayground.Data;
using MongoPlayground.Data.Entities;
using MongoPlayground.Extensions;

namespace MongoPlayground.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services
            .AddBusiness<DbContextConfigurator>();

        var provider = services.BuildServiceProvider();

        using var scope = provider.CreateAsyncScope();

        var theRealScopedProvider = scope.ServiceProvider;
        var dbContext = theRealScopedProvider.GetRequiredService<ApplicationDbContext>();

        var canConnect = dbContext.Database.CanConnect();
        System.Console.WriteLine($"Can connect: {canConnect}");

        dbContext.Database.EnsureCreated();

        var query = dbContext.Users;
        var materialization = query.ToList();
        System.Console.WriteLine(materialization.Count);

        dbContext.Add(new User() {Age = 42, Name = "gigi", Id = Guid.NewGuid()});
        dbContext.Add(new User() {Age = 43, Name = "Marimmo", Id = Guid.NewGuid()});
        dbContext.SaveChanges();

        dbContext.ChangeTracker.Clear();

        foreach (var user in dbContext.Users)
        {
            System.Console.WriteLine(user);
        }

        Mimmo.Things();
    }
}
