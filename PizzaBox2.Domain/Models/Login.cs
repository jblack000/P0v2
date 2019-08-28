using System;

namespace PizzaBox2.Domain.Models
{
  public class Login
  {
    public string userName { get; set; }
    public string userPassword { get; set; }

    public Login()
    {
      System.Console.Write("Please enter your username: ");
      userName = Console.ReadLine();
      System.Console.Write("Please enter your password: ");
      userPassword = Console.ReadLine();
      System.Console.WriteLine($"Welcome back {userName}!");

      Menu menu = new Menu();
    }
  }
}