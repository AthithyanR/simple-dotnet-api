using System.ComponentModel.DataAnnotations;

namespace GameStore.Dtos;

public record CreateGameDTO(
    [Required][StringLength(50)] string Name,
    [Required] Guid GenreId,
    [Required][Range(0, 1000)] decimal Price
);