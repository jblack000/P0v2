using System;
using PizzaBox2.Domain.Recipes;

namespace PizzaBox2.Domain.Models
{
  public class Menu
  {
    string response = "";

    public Menu()
    {

      System.Console.Write("Please select [A} to order a pizza or [B] to quit: ");
      response = Console.ReadLine();

      if (response == "a")
      {
        System.Console.WriteLine("Please select [A] to order a specialty pizza or [B] for a custom pizza: ");
        response = Console.ReadLine();

        if (response == "a")
        {
          Chicago chicago = new Chicago();
        }
        else
        {
          System.Console.WriteLine("You selected a custom pizza");
        }
      }
      else
      {
        System.Console.WriteLine("Goodbye");
      }


    }
  }
}