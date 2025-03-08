using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UrlShortener.Data.Extensions
{
    public static class DatabaseServiceExtension
    {
        public static IServiceCollection AddDatabaseService(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            var awsOptions = configuration.GetAWSOptions();
            services.AddDefaultAWSOptions(awsOptions);
            services.AddAWSService<IAmazonDynamoDB>();
            services.AddScoped<IDatabaseService, DatabaseService>();
            return services;
        }
    }
}
