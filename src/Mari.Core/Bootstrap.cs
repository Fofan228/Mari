using Microsoft.Extensions.DependencyInjection;

namespace Mari.Core;

public static class Bootstrap
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}