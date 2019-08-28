namespace PizzaBox2.Domain.Models
{
  public class Size
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Size(string name)
    {
      Name = name;
    }
  }
}