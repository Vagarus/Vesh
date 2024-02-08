using Microsoft.EntityFrameworkCore;

using Vesher.Api.Information.Models;

namespace Vesher.Api.Information;

public class VeshDbContext : DbContext
{
    public DbSet<Goal> Goals { get; set; }  

    public DbSet<Page> Notes { get; set; }  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
