using Amazon.DynamoDBv2.DataModel;

namespace UrlShortener.Models;

[DynamoDBTable("ShortenedUrls")]
public class ShortUrl
{
    [DynamoDBHashKey] // Partition Key
    public string ShortCode { get; set; } = default!;

    [DynamoDBProperty]
    public string LongUrl { get; set; } = default!;

    [DynamoDBProperty]
    public long CreatedAt { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    [DynamoDBProperty]
    public long Expiration { get; set; } // TTL for auto-delete

    [DynamoDBProperty]
    public int Clicks { get; set; } = 0;
}
