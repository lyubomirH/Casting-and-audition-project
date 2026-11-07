using CastingStars.Data.Entities;

namespace CastingStars.Data.Entities;

/// <summary>Кандидатура на кандидат по даден кастинг.</summary>
public class Application
{
    public int Id { get; set; }
    public int CastingId { get; set; }
    public Casting? Casting { get; set; }
    public int CandidateId { get; set; }
    public User? Candidate { get; set; }
    public string CoverLetter { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
    public DateTime AppliedOn { get; set; } = DateTime.UtcNow;
    public Audition? Audition { get; set; }
}
