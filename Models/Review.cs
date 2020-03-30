namespace TravelAPI.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public int DestinationId { get; set; }
    public string ReviewText { get; set; }
    public string user_name { get; set; }
    public string Rating { get; set; }
  }
}