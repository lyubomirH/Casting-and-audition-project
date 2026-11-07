namespace CastingStars.Data.Entities;

/// <summary>Насрочено прослушване по кандидатура.</summary>
public class Audition
{
    public int Id { get; set; }
    public int ApplicationId { get; set; }
    public Application? Application { get; set; }
    public DateTime ScheduledOn { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
}