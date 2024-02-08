using System.ComponentModel.DataAnnotations;

namespace Vesher.Api.Information.Models;

public class Account
{
    [Key]
    public int Id { get; set; } 

    public string Username { get; set; }

    public string Password { get; set; }    

    public ICollection<Goal> Goals { get; set; }    
}
