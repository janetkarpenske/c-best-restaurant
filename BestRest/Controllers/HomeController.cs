using Microsoft.AspNetCore.Mvc;

namespace BestRest.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}