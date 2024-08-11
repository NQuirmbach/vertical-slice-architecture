using Marten;

namespace BookingSystem.Movies.Handlers;

public record CreateMovie;

public static class CreateMovieHandler
{
    public static async Task HandleAsync(CreateMovie message, IDocumentSession session,
        CancellationToken cancellationToken)
    {
        
    }
}