using System.Collections.Generic;
namespace BakeryVendors.Models
{
  public class Order
  {
    string Title { get; set; }
    string Description { get; set; }
    string Price { get; set; }
    string Date { get; set; }
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
  }
}