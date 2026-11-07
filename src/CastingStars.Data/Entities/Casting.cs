using CastingStars.Data.Entities;

namespace CastingStars.Data.Entities;

/// <summary>Кастинг, публикуван от организатор.</summary>
public class Casting
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Requirements { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public int OrganizerId { get; set; }
    public User? Organizer { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public ICollection<Application> Applications { get; set; } = new List<Application>();
}