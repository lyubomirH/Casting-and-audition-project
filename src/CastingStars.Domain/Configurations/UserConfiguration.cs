using CastingStars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CastingStars.Domain.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.FullName).IsRequired().HasMaxLength(120);
        builder.Property(u => u.Email).IsRequired().HasMaxLength(200);
        builder.HasIndex(u => u.Email).IsUnique();
        builder.Property(u => u.Role).IsRequired().HasMaxLength(20);

        // Popularity: default 0, в диапазон 0..100
        builder.Property(u => u.Popularity).HasDefaultValue(0);
        builder.ToTable(t => t.HasCheckConstraint("CK_User_Popularity", "[Popularity] >= 0 AND [Popularity] <= 100"));
    }
}