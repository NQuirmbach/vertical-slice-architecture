using FastEndpoints;
using Wolverine;

namespace BookingSystem.Movies.Commands;

public class ImportMovies : Endpoint<ImportMovies.Request, ImportMovies.Response>
{
    private readonly IMovieImportService _importService;
    private readonly IMessageBus _bus;

    public ImportMovies(IMovieImportService importService, IMessageBus bus)
    {
        _importService = importService;
        _bus = bus;
    }

    public record Request;

    public record Response(int Count);

    public override void Configure()
    {
        Post("/movies/import");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
    }
}