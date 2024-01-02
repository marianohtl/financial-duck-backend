using financial_duck_backend.Infra.Context;
using Microsoft.Extensions.DependencyInjection;

namespace financial_duck_backend.Infra;
public static class InfraServiceRegistration
{
    public static IServiceCollection AddInfraServices(this IServiceCollection services)
    {
        services.AddTransient<DBContext>();
        return services;
    }
}
