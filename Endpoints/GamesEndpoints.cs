using GameStore.Dtos;
using GameStore.Data;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class GamesEndpoints
{
    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/games");

        group.MapGet("/", async (GameStoreContext dbContext) => await dbContext.Games.Include(g => g.Genre).Select(g => g.ToDTO()).ToListAsync());

        group.MapGet("/{id}", async (Guid id, GameStoreContext dbContext) =>
        {
            var game = await dbContext.Games.Include(g => g.Genre).FirstOrDefaultAsync(g => g.Id == id);
            if (game is null) return Results.NotFound();
            return Results.Ok(game.ToDTO());
        });

        group.MapPost("/", async (CreateGameDTO newGame, GameStoreContext dbContext) =>
        {
            var game = newGame.ToEntity();
            game.Genre = dbContext.Genres.Find(game.GenreId);
            dbContext.Games.Add(game);
            await dbContext.SaveChangesAsync();

            return Results.Created($"/games/{game.Id}", game.ToDTO());
        })
        .WithParameterValidation();

        group.MapPut("/{id}", async (Guid id, UpdateGameDTO game, GameStoreContext dbContext) =>
        {
            var existingGame = await dbContext.Games.FirstOrDefaultAsync(g => g.Id == id);
            if (existingGame is null) return Results.NotFound();

            existingGame.Name = game.Name;
            existingGame.GenreId = game.GenreId;
            existingGame.Genre = dbContext.Genres.Find(game.GenreId);
            existingGame.Price = game.Price;

            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        })
        .WithParameterValidation();

        group.MapDelete("/{id}", async (Guid id, GameStoreContext dbContext) =>
        {
            var existingGame = await dbContext.Games.FirstOrDefaultAsync(g => g.Id == id);
            if (existingGame is null) return Results.NotFound();

            dbContext.Games.Remove(existingGame);
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        return group;
    }
}