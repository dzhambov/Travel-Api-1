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

    // GET api/destinations
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
  }
}