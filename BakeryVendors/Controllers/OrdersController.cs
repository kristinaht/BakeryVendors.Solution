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

    // [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    // public ActionResult
  }
}