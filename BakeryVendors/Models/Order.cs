using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _orderInstances = new List<Order>{}; //for creating order IDs
    public Order(string title, string description, string price, string date)

    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _orderInstances.Add(this);
      Id = _orderInstances.Count;
    }

    public static List<Order> GetAll()
    {
      return _orderInstances;
    }

    public static Order Find(int searchId)
    {
      return _orderInstances[searchId - 1];
    }
  }
}