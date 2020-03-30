using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelAPIContext _db;
    
    public ReviewsController(TravelAPIContext db)
    {
      _db = db;
    }

    // GET api/reviews
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string user_name, int rating)
    {
      var query = _db.Review.AsQueryable();

      if (user_name != null)
      {
        query = query.Where(entry => entry.user_name == user_name);
      }

      if (rating >= 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      return query.ToList();
    }

    // POST api/reviews
    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Review.Add(review);
      Destination destination = _db.Destination.FirstOrDefault(dest => dest.DestinationId == review.DestinationId);
      destination.Reviews.Add(review);
      destination.Rating = (destination.Reviews.Sum(dest => destination.Rating)/destination.Reviews.Count);
      _db.Entry(destination).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // GET api/reviews/5
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
      return _db.Review.FirstOrDefault(entry => entry.ReviewId == id);
    }

    // PUT api/reviews/5
    [HttpPut("{id}")]
    public void Put(string user, int id, [FromBody] Review review)
    {
      review.ReviewId = id;
      if (review.user_name == user)
      {
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
      }
    }

    // DELETE api/reviews/5
    [HttpDelete("{id}")]
    public void Delete(string user, int id)
    {
      var reviewToDelete = _db.Review.FirstOrDefault(entry => entry.ReviewId == id);
      if (reviewToDelete.user_name == user)
      {
      _db.Review.Remove(reviewToDelete);
      _db.SaveChanges();
      }
    }  
  }
}