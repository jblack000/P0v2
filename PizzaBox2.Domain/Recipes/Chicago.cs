using System;
using System.Collections.Generic;
using PizzaBox2.Domain.Models;

namespace PizzaBox2.Domain.Recipes
{
  public class Chicago
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Topping { get; set; }

    public string sizeSelection;
    public string crustSelection;
    public string toppingSelection;
    public string response;

    public Chicago()
    {
      //System.Console.Write("Please enter the size: ");
      sizeSelection = "medium";
      Size size = new Size(sizeSelection);
      Size = size;

      //System.Console.Write("Please enter the crust: ");
      crustSelection = "deep dish";
      Crust crust = new Crust(crustSelection);
      Crust = crust;

      List<Topping> toppings = new List<Topping>();
      toppings.Add(new Topping("cheese"));
      toppings.Add(new Topping("marinara sauce"));

      for (int i = 3; i > 0; i--)
      {
        System.Console.Write($"Please enter {i} more topping{(i == 1 ? "" : "s")}: ");
        toppingSelection = Console.ReadLine();
        toppings.Add(new Topping(toppingSelection));
      }
      Topping = toppings;

      display(Size, Crust, Topping);
    }

    public void display(Size s, Crust c, List<Topping> t)
    {
      System.Console.WriteLine();
      System.Console.WriteLine("Is this order correct?\n");
      System.Console.WriteLine($"Size ===> {s.Name}");
      System.Console.WriteLine($"Crust ===> {c.Name}");
      foreach (var i in t)
      {
        System.Console.WriteLine($"Topping ===> {i.Name}");
      }
      System.Console.WriteLine();
      System.Console.Write("Select [Y]es for [N]o: ");
      response = Console.ReadLine();
    }
  }
}