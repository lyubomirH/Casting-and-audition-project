namespace CastingStars.Data.Entities;

/// <summary>
/// Потребител на платформата. Ролята определя достъпа,
/// а Popularity е метрика за ангажираност в общността.
/// </summary>
public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "Candidate"; // Candidate, Organizer, Admin
    public string Bio { get; set; } = string.Empty;
    public string ProfilePictureUrl { get; set; } = string.Empty;

    /// <summary>Метрика за популярност (0..100).</summary>
    public int Popularity { get; set; } = 0;

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public ICollection<Project> Projects { get; set; } = new List<Project>();
    public ICollection<Application> Applications { get; set; } = new List<Application>();
    public ICollection<Casting> OrganizedCastings { get; set; } = new List<Casting>();
}