using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vesher.Api.Information.Models;

[Table("goal")]
public class Goal
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }
    
    public string LinkUrl { get; set; } = null!;

    public ICollection<Page> Notes { get; set; }

    public Account Account { get; set; }

    public int AccountId { get; set; }  
}
