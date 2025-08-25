using Microsoft.EntityFrameworkCore;

namespace GameStore.Data;

public static class DataExtension
{
    public static void MigrateDatabase(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        db.Database.Migrate();
    }
}