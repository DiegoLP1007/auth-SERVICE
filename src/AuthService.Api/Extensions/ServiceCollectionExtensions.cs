using AuthService.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Configurar base de datos PostgreSQL
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                   .UseSnakeCaseNamingConvention());

        // Aquí puedes registrar tus repositorios cuando los tengas listos
        // services.AddScoped<IUserRepository, UserRepository>();
        
        // Configurar health checks
        services.AddHealthChecks();

        return services;
    }
}