namespace BakeryVendors.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Artist> _instances = new List<Artist>{};
    public List<Order> Orders { get; set; }
  }
}