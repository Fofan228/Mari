using Microsoft.Extensions.DependencyInjection;

namespace Mari.Data;

public static class Bootstrap
{
    public static IServiceCollection AddData(this IServiceCollection services)
    {
        return services;
    }
}