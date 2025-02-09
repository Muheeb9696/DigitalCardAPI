using ServiceTier.Api.Common.Mapping;

namespace ServiceTier.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddMappings();
            return services;
        }
    }
}
