using Microsoft.Extensions.DependencyInjection;
using MongoPlayground.Data.Dependencies;
using MongoPlayground.Data.Extensions;

namespace MongoPlayground.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusiness<TDbContextConfigurator>(this IServiceCollection source)
        where TDbContextConfigurator : class, IDbContextConfigurator
    {
        source
            .AddData<TDbContextConfigurator>();

        return source;
    }
}
