using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener.Models;

namespace UrlShortener.Application
{
    public interface IUrlService
    {
        Task<string> ShortenUrlAsync(string longUrl, int expirationDays);
        Task<string?> GetLongUrlAsync(string shortCode);
    }
}
