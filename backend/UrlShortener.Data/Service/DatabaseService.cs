using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using UrlShortener.Models;

namespace UrlShortener.Data
{
    public class DatabaseService : IDatabaseService
    {
        private readonly DynamoDBContext _dbContext;

        public DatabaseService(IAmazonDynamoDB dynamoDb)
        {
            _dbContext = new DynamoDBContext(dynamoDb);
        }

        public async Task SaveUrlAsync(ShortUrl url)
        {
            await _dbContext.SaveAsync(url);
        }

        public async Task<ShortUrl?> GetUrlAsync(string shortCode)
        {
            return await _dbContext.LoadAsync<ShortUrl>(shortCode);
        }

        public async Task IncrementClickCountAsync(string shortCode)
        {
            var url = await _dbContext.LoadAsync<ShortUrl>(shortCode);
            if (url != null)
            {
                url.Clicks++;
                await _dbContext.SaveAsync(url);
            }
        }
    }
}
