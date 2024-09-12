using Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence.Services
{

    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IWorkOrderService, WorkOrderService>();

            return services;
        }
    }
}

