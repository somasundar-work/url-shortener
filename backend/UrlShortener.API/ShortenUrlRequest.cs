using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.API
{
    public class ShortenUrlRequest
    {
        public string LongUrl { get; set; } = default!;
        public int ExpirationDays { get; set; } = 30;
    }
}
