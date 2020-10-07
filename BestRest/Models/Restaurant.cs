using System.Collections.Generic;

namespace BestRest.Models
{
  public class Restaurant
  {
    public Restaurant()
      {
        this.Reviews = new HashSet<Review>();
      }

    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }
  }
}