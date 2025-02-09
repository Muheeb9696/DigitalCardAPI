using DigitalCard.Domain.Entities;
using DigitalCard.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using ServiceTier.Infrastructure.Context;

namespace ServiceTier.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services
            )
        {
            services.AddSingleton<DBContext>();
            services.AddScoped<InevigationRepository, NevigationRepository>();
            // services.Configure<USERNAME_PREFIX>(configuration.GetSection("USERNAME_PREFIX"));
            return services;
        }
    }
}
