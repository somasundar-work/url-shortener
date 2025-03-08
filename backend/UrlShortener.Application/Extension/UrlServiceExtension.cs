using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UrlShortener.Data.Extensions;

namespace UrlShortener.Application.Extension
{
    public static class UrlServiceExtension
    {
        public static IServiceCollection AddUrlService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseService(configuration);
            services.AddScoped<IUrlService, UrlService>();
            return services;
        }
    }
}
