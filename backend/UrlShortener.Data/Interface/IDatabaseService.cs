using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener.Models;

namespace UrlShortener.Data
{
    public interface IDatabaseService
    {
        Task SaveUrlAsync(ShortUrl url);
        Task<ShortUrl?> GetUrlAsync(string shortCode);
        Task IncrementClickCountAsync(string shortCode);
    }
}
