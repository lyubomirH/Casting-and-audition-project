using CastingStars.Data.Entities;
using CastingStars.Domain;
using CastingStars.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CastingStars.Data.Seed;

public static class DbSeeder
{
    public static async Task SeedAsync(CastingStarsDbContext context)
    {
        if (await context.Users.AnyAsync()) return;

        var admin = new User
        {
            FullName = "Admin CastingStars",
            Email = "admin@castingstars.local",
            PasswordHash = "SEED_HASH",
            Role = "Admin",
            Bio = "Системен администратор",
            Popularity = 100
        };
        var organizer = new User
        {
            FullName = "Demo Organizer",
            Email = "organizer@castingstars.local",
            PasswordHash = "SEED_HASH",
            Role = "Organizer",
            Bio = "Организатор на кастинги",
            Popularity = 50
        };
        var candidate = new User
        {
            FullName = "Demo Candidate",
            Email = "candidate@castingstars.local",
            PasswordHash = "SEED_HASH",
            Role = "Candidate",
            Bio = "Начинаещ актьор",
            Popularity = 10
        };

        context.Users.AddRange(admin, organizer, candidate);
        await context.SaveChangesAsync();
    }
}