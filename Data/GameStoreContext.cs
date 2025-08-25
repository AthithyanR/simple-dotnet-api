using GameStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var actionGenreId = "04075994-f276-4f05-b979-be9e1d79f979";
        var adventureGenreId = "7fcb0a7d-eb7a-4454-a493-eaab14106cc8";
        var rpgGenreId = "d9cca864-5103-4142-8041-08c1fca7b822";
        var strategyGenreId = "a7a751d1-2e58-46cf-9504-020dac13f40a";
        var sportsGenreId = "38fc59a2-7530-4f18-8ae6-034016fc9c4f";
        var racingGenreId = "42536eca-eb40-485d-b46b-06d37b317efa";

        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = Guid.Parse(actionGenreId), Name = "Action" },
            new Genre { Id = Guid.Parse(adventureGenreId), Name = "Adventure" },
            new Genre { Id = Guid.Parse(rpgGenreId), Name = "RPG" },
            new Genre { Id = Guid.Parse(strategyGenreId), Name = "Strategy" },
            new Genre { Id = Guid.Parse(sportsGenreId), Name = "Sports" },
            new Genre { Id = Guid.Parse(racingGenreId), Name = "Racing" }
        );

        var gameActionId = "0fb7c267-3369-4f48-84f6-b04464f6c728";
        var gameAdventureId = "d25f5b7f-6a30-448e-b477-7dcba2a6aee8";
        var gameRpgId = "188e5a5b-1265-4da6-af67-3360f053fd32";
        var gameStrategyId = "4fa4c6b0-f896-4636-b68a-d37775546476";
        var gameSportsId = "e31d8c36-8efb-468d-bd4a-5ff74f7ba7e5";
        var gameRacingId = "300bd70a-5483-438d-ba79-0f23241df42c";

        modelBuilder.Entity<Game>().HasData(
            new Game { Id = Guid.Parse(gameActionId), Name = "Game Action", GenreId = Guid.Parse(actionGenreId), Price = 100 },
            new Game { Id = Guid.Parse(gameAdventureId), Name = "Game Adventure", GenreId = Guid.Parse(adventureGenreId), Price = 200 },
            new Game { Id = Guid.Parse(gameRpgId), Name = "Game RPG", GenreId = Guid.Parse(rpgGenreId), Price = 300 },
            new Game { Id = Guid.Parse(gameStrategyId), Name = "Game Strategy", GenreId = Guid.Parse(strategyGenreId), Price = 400 },
            new Game { Id = Guid.Parse(gameSportsId), Name = "Game Sports", GenreId = Guid.Parse(sportsGenreId), Price = 500 },
            new Game { Id = Guid.Parse(gameRacingId), Name = "Game Racing", GenreId = Guid.Parse(racingGenreId), Price = 600 }
        );
    }
}