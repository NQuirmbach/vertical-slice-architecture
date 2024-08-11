namespace BookingSystem.Movies.Services;

public class OpenMovieDbImportService : IMovieImportService
{
    public ValueTask<object[]> LoadAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

public class OpenMovieDbSettings
{
    public required string Endpoint { get; init; }
    public required string ApiKey { get; init; }
}