namespace PizzaBox2.Domain.Models
{
  public class Topping
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Topping(string name)
    {
      Name = name;
    }
  }
}