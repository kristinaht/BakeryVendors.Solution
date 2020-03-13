using Microsoft.AspNetCore.Mvc;
using BakeryVendors.Models;
using System.Collections.Generic;


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

   [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show (int vendorId, int orderId)
    {
      Order newOrder = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", newOrder);
      model.Add("vendor", vendor);
      return View(model);

      
    }
  }
}