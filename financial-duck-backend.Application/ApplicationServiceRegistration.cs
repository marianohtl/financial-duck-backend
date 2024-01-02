using financial_duck_backend.Infra;
using Microsoft.Extensions.DependencyInjection;
namespace financial_duck_backend.Application;
public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddInfraServices();
        return services;
    }
}
