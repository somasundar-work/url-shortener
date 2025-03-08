using System.Security.Cryptography;
using System.Text;
using UrlShortener.Data;
using UrlShortener.Models;

namespace UrlShortener.Application
{
    public class UrlService : IUrlService
    {
        private readonly IDatabaseService _databaseService;

        public UrlService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<string> ShortenUrlAsync(string longUrl, int expirationDays)
        {
            var shortCode = GenerateShortCode(longUrl);
            var expiration = DateTimeOffset.UtcNow.AddDays(expirationDays).ToUnixTimeSeconds();

            var shortUrl = new ShortUrl
            {
                ShortCode = shortCode,
                LongUrl = longUrl,
                Expiration = expiration,
            };

            await _databaseService.SaveUrlAsync(shortUrl);
            return shortCode;
        }

        public async Task<string?> GetLongUrlAsync(string shortCode)
        {
            var response = await _databaseService.GetUrlAsync(shortCode);
            if (response == null || response.Expiration < DateTimeOffset.UtcNow.ToUnixTimeSeconds())
            {
                return null;
            }
            response.Clicks++;
            await _databaseService.SaveUrlAsync(response);
            return response.LongUrl;
        }

        private string GenerateShortCode(string input)
        {
            try
            {
                var hash = MD5.HashData(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                foreach (var b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString().Substring(0, 6);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
