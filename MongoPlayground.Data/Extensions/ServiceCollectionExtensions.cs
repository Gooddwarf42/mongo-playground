using Microsoft.Extensions.DependencyInjection;
using MongoPlayground.Data.Dependencies;

namespace MongoPlayground.Data.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddData<TDbContextConfigurator>(this IServiceCollection source)
        where TDbContextConfigurator : class, IDbContextConfigurator
    {
        source
            .AddDbContext<ApplicationDbContext>();

        source
            .AddSingleton<IDbContextConfigurator, TDbContextConfigurator>();

        return source;
    }
}
