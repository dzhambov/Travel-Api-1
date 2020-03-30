using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
  public class TravelAPIContext : DbContext
  {
    public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Destination> Destination { get; set; }
    public DbSet<Review> Review { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
          .HasData(
            new Destination { DestinationId = 1, Country = "United States", City = "New York City", Rating = 7 },
            new Destination { DestinationId = 2, Country = "England", City = "London", Rating = 10 },
            new Destination { DestinationId = 3, Country = "Canada", City = "Toronto", Rating = 2 },
            new Destination { DestinationId = 4, Country = "China", City = "Guangzho", Rating = 4 },
            new Destination { DestinationId = 5, Country = "Northern Ireland", City = "Belfast", Rating = 10 } 
          );
    }
  }
}