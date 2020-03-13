using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Vendor> _vendorInstances = new List<Vendor>{};
    public List<Order> Orders { get; set; }

    publid Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendorInstances.Add(this);
      Id = _vendorInstances.Count;
      Orders = new List<Order>(); //add {}?
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorInstances[searchId - 1];
    }
  }
}