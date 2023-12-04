using Refit;
using YoutubeClone.Http;

namespace YoutubeClone.Extensions;

internal static class HttpExtensions
{
    public static IServiceCollection RegisterHttpClients(this IServiceCollection services)
    {
        services.AddRefitClient<IYoutubeClient>()
            .ConfigureHttpClient((sp, client) =>
            {
                var configuration = sp.GetRequiredService<IConfiguration>();

                client.BaseAddress = new Uri("https://youtube-v31.p.rapidapi.com/");

                var headers = client.DefaultRequestHeaders;
                headers.Add("X-RapidAPI-Key", configuration["RapidApiKey"]);
                headers.Add("X-RapidAPI-Host", "youtube-v31.p.rapidapi.com");
            });

        return services;
    }
}