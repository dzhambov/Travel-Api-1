using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private TravelAPIContext _db;

    public DestinationsController(TravelAPIContext db)
    {
      _db = db;
    }

     // GET api/destinations
    [HttpGet]
    public ActionResult<IEnumerable<Destination>> Get(string country, string city, int? rating)
    {
      var query = _db.Destination.AsQueryable();

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (rating != null)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      return query.ToList();
    }

    // POST api/Destinations
    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destination.Add(destination);
      _db.SaveChanges();
    }

    // GET api/destinations/5
    [HttpGet("{id}")]
    public ActionResult<Destination> Get(int id)
    {
      return _db.Destination.FirstOrDefault(entry => entry.DestinationId == id);
    }

    // PUT api/destinations/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Destination destination)
    {
      destination.DestinationId = id;
      _db.Entry(destination).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/destinations/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var destinationToDelete = _db.Destination.FirstOrDefault(entry => entry.DestinationId == id);
      _db.Destination.Remove(destinationToDelete);
      _db.SaveChanges();
    }  
  }
}