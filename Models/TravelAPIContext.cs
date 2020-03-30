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
            new Destination { DestinationId = 1, Country = "United States", City = "New York City", },
            new Destination { DestinationId = 2, Country = "England", City = "London", },
            new Destination { DestinationId = 3, Country = "Canada", City = "Toronto", },
            new Destination { DestinationId = 4, Country = "China", City = "Guangzho",  },
            new Destination { DestinationId = 5, Country = "Northern Ireland", City = "Belfast", } 
          );
      builder.Entity<Review>()
          .HasData(
            new Review { ReviewId = 1, DestinationId = 1, ReviewText = "United States", user_name = "New York user_name", Rating = 7 },
            new Review { ReviewId = 2, DestinationId = 2, ReviewText = "England", user_name = "London", Rating = 10 },
            new Review { ReviewId = 3, DestinationId = 3, ReviewText = "Canada", user_name = "Toronto", Rating = 2 },
            new Review { ReviewId = 4, DestinationId = 4, ReviewText = "China", user_name = "Guangzho", Rating = 4 },
            new Review { ReviewId = 5, DestinationId = 5, ReviewText = "Northern Ireland", user_name = "Belfast", Rating = 10 } 
          );
    }
  }
}