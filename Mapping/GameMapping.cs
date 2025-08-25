using GameStore.Dtos;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class GameMapping
{
    public static GameDTO ToDTO(this Game game)
    {
        return new GameDTO(game.Id, game.Name, game.Genre?.Name ?? "Unknown", game.Price);
    }

    public static Game ToEntity(this CreateGameDTO createGameDTO)
    {
        return new Game {
            Id = Guid.NewGuid(),
            Name = createGameDTO.Name,
            GenreId = createGameDTO.GenreId,
            Price = createGameDTO.Price
        };
    }

    public static Game ToEntity(this UpdateGameDTO updateGameDTO, Game existingGame)
    {
        return new Game {
            Id = existingGame.Id,
            Name = updateGameDTO.Name,
            GenreId = updateGameDTO.GenreId,
            Price = updateGameDTO.Price
        };
    }
}