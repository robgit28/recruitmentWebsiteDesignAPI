
using recruitmentWebsiteDesign.Core.Workers;
using recruitmentWebsiteDesign.Data.Repositories;
using recruitmentWebsiteDesign.Data.Services;

namespace recruitmentWebsiteDesign.API.Configuration
{
    public static class ServiceCollectionExtensions
    {
        //public static IServiceCollection AddConfiguration()
        //{ 
        
        //}

        public static IServiceCollection AddCoreDpendencies(this IServiceCollection services)
        {
            services.AddScoped<IContactWorker, ContactWorker>();
            
            return services;
        }

        public static IServiceCollection AddDataDpendencies(this IServiceCollection services)
        {
            services.AddScoped<IContactRepository, ContactRepository>();
            //services.AddSingleton<IEmailService, EmailService>();

            return services;
        }

    }
}
