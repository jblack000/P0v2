namespace PizzaBox2.Domain.Models
{
  public class Crust
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Crust(string name)
    {
      Name = name;
    }
  }
}