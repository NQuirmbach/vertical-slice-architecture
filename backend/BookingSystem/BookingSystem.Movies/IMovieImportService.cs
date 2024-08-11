namespace BookingSystem.Movies;

public interface IMovieImportService
{
    ValueTask<object[]> LoadAsync(CancellationToken cancellationToken);
}