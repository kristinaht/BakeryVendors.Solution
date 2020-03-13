using Microsoft.AspNetCore.Mvc;
// using BakeryVendors.Models;

namespace BakeryVendors.Controllers
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}