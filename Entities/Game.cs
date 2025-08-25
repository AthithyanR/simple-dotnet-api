namespace GameStore.Entities;

public class Game
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public Guid GenreId { get; set; }
    public Genre? Genre { get; set; }
    public required decimal Price { get; set; }
}