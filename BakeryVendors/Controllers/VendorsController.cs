using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryVendors.Models;

namespace BakeryVendors.Controllers
{
  public class VendorsController: Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")] 
    //this Create route posts created vendor information to index page
    public ActionResult Create(string name, string description) 
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string orderDescription, string price, string date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = foundVendor.Orders;
      Order newOrder =new Order(title, orderDescription, price, date);
      model.Add("vendor", foundVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }

  }
}