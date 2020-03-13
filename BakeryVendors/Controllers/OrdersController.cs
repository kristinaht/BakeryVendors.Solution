using Microsoft.AspNetCore.Mvc;
using BakeryVendors.Models;


namespace BakeryVendors.Controllers
{
  public class OrderController: Controller
  {
    [HttpGet("/vendors/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    } 
  }
}