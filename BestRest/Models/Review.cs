using System.Collections.Generic;

namespace BestRest.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Title { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
    public int RestaurantId { get; set; }
    public int Stars { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}