using DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess;

public class BreakAwayContext : DbContext
{
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Lodging> Lodgings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DestinationConfiguration());
        modelBuilder.ApplyConfiguration(new LodgingConfiguration());
    }
}