using Microsoft.EntityFrameworkCore;

namespace BestRest.Models
{
  public class BestRestContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public BestRestContext(DbContextOptions options) : base(options) { }

    
  }
}