using CastingStars.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CastingStars.Domain;

public class CastingStarsDbContext : DbContext
{
    public CastingStarsDbContext(DbContextOptions<CastingStarsDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Casting> Castings => Set<Casting>();
    public DbSet<Application> Applications => Set<Application>();
    public DbSet<Audition> Auditions => Set<Audition>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CastingStarsDbContext).Assembly);
    }
}