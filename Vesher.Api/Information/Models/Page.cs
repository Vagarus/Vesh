using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vesher.Api.Information.Models;

public enum PageType
{
    Note,
    Profile,
}

[Table("note")]
public class Page
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string LinkUrl { get; set; } = null!;

    public PageType Type { get; set; }

    public ICollection<Goal> Goals { get; set; }    

    public ICollection<Link> Links { get; set; }

    public ICollection<Resource> Resources { get; set; }    
}
