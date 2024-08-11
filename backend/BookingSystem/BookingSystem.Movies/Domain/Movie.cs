namespace BookingSystem.Movies.Domain;

public class Movie
{
    public MovieId Id { get; set; } = MovieId.From(Guid.NewGuid());
    public required string Genre { get; set; }
    public required string Description { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public required string Rating { get; set; }
    public required string PosterUrl { get; set; }
}