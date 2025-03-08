using Microsoft.AspNetCore.Mvc;
using UrlShortener.Application;

namespace UrlShortener.API
{
    public static class Endpoints
    {
        public static WebApplication MapUrlShortenerEndpoints(this WebApplication app)
        {
            app.MapPost(
                "/api/shorten",
                async ([FromBody] ShortenUrlRequest request, IUrlService service, IConfiguration configuration) =>
                {
                    if (request == null || string.IsNullOrEmpty(request.LongUrl))
                    {
                        return Results.BadRequest("Invalid request");
                    }
                    var baseUrl = configuration["BaseUrl"];
                    if (string.IsNullOrEmpty(baseUrl))
                    {
                        return Results.BadRequest("Invalid configuration");
                    }

                    var shortCode = await service.ShortenUrlAsync(request.LongUrl, request.ExpirationDays);
                    return Results.Ok(new { shortUrl = $"{baseUrl}/{shortCode}" });
                }
            );

            app.MapGet(
                "/api/{shortCode}",
                async (string shortCode, IUrlService service) =>
                {
                    var url = await service.GetLongUrlAsync(shortCode);
                    if (url == null)
                        return Results.NotFound("URL not found");

                    return Results.Redirect(url);
                }
            );
            return app;
        }
    }
}
