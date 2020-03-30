using System.Collections.Generic;
using System.Linq;

namespace TravelAPI.Models
{
  
  public class Destination
  {
    private TravelAPIContext _db;

    public void DestinationsController(TravelAPIContext db)
    {
      _db = db;
    }
    public int DestinationId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public int Rating { get; set; }
    public List<Review> Reviews {get;set;}

    // public Destination()
    // {
    //   Reviews = _db.Review.Where(entry => entry.DestinationId == DestinationId).ToList();
    //   Rating = (this.Reviews.Sum(destination => destination.Rating)/this.Reviews.Count);
    // }
  }
}