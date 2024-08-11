using BookingSystem.Infra;
using BookingSystem.Movies.Domain;
using BookingSystem.Movies.Services;
using Marten;
using Microsoft.Extensions.Options;

namespace BookingSystem.Movies;

public class MoviesFeature : IFeature
{
    public static void AddServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IConfigureMarten, MoviesFeature>();

        services.Configure<OpenMovieDbSettings>(configuration.GetSection("OpenMovieDb"));
        services.AddTransient<IMovieImportService, OpenMovieDbImportService>();
        services.AddHttpClient<OpenMovieDbImportService>((s, client) =>
        {
            var settings = s.GetRequiredService<IOptions<OpenMovieDbSettings>>().Value;

            client.BaseAddress = new Uri(settings.Endpoint);
        });
    }
    
    public void Configure(IServiceProvider services, StoreOptions options)
    {
        options.Schema.For<Movie>();
    }
}