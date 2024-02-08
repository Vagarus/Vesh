using System.ComponentModel.DataAnnotations;

namespace Vesher.Api.Information.Models;

public class Resource
{
    [Key]
    public int Id { get; set; }

    public Link LinkResource { get; set; }   
}
