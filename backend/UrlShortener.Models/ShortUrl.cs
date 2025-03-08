using Amazon.DynamoDBv2.DataModel;

namespace UrlShortener.Models
{
    [DynamoDBTable("ShortenedUrls")]
    public class ShortUrl
    {
        [DynamoDBHashKey]
        public string ShortCode { get; set; } = default!;

        [DynamoDBProperty]
        public string LongUrl { get; set; } = default!;

        [DynamoDBProperty]
        public long CreatedAt { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        [DynamoDBProperty]
        public long Expiration { get; set; }

        [DynamoDBProperty]
        public int Clicks { get; set; } = 0;
    }
}
