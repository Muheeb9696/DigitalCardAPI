using DigitalCard.Application.Services;
using DigitalCard.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ServiceTier.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<Inevigation, Nevigation>();
            return services;
        }
    }
}
