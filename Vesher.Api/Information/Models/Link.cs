using System.ComponentModel.DataAnnotations;

namespace Vesher.Api.Information.Models;

public class Link
{
    [Key]
    public int Id { get; set; } 

    public string LinkUrl { get; set; }

}
