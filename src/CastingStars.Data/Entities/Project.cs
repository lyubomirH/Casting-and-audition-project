using CastingStars.Data.Entities;

namespace CastingStars.Data.Entities;

/// <summary>Творчески проект, публикуван от потребител.</summary>
public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string MediaUrl { get; set; } = string.Empty;
    public int OwnerId { get; set; }
    public User? Owner { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
}