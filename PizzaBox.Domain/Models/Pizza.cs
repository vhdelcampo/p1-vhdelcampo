using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public long PizzaId { get; set; }
    public string Name { get; set; }
    public Decimal Price { get; set; }
    public string Size { get; set; }
    public string Topping { get; set; }
    public List<string> PizzaToppings { get; set; }
    public string Crust { get; set; }

    #region Navigational Properties
    public Order Order { get; set; }
    #endregion

    public Pizza()
    {
      PizzaId = DateTime.Now.Ticks;
    }

    public Pizza(int type, int size)
    {
      if (size == 1)
      {
        Size = "Small";
      }
      else if (size == 2)
      {
        Size = "Medium";
      }
      else
      {
        Size = "Large";
      }
      var t1 = "Cheese";
      var t2 = "Tomato Sauce";
      var t3 = "Pepperoni";
      var t4 = "Meat";
      var t5 = "Sausage";
      var t6 = "Ham";
      var t7 = "Pineapple";

      PizzaToppings.Add(t1);
      PizzaToppings.Add(t2);
      if (type == 1)
      {
        Name = "Pepperoni";
        Crust = "Regular";
        PizzaToppings.Add(t1);
        PizzaToppings.Add(t2);
        PizzaToppings.Add(t3);
      }
      else if (type == 2)
      {
        Name = "Meat";
        Crust = "Deep Dish";
        PizzaToppings.Add(t4);
        PizzaToppings.Add(t5);
      }
      else if (type == 3)
      {
        Name = "Hawaiian";
        Crust = "Thin";
        PizzaToppings.Add(t6);
        PizzaToppings.Add(t7);
      }
      else if (type == 4)
      {
        Name = "New York";
        Crust = "New York";
      }
    }

    enum PizzaType
    {
      Pepperoni = 1,
      Meat = 2,
      Hawaiian = 3,
      NY = 4
    }

    enum PizzaSize
    {
      Small = 1,
      Medium = 2,
      Large = 3
    }

    public override string ToString()
    {
      return $"{Size ?? "N/A"} {Name ?? "N/A"} {GetPrice()} ";
    }

    public void PrintToppings()
    {
      foreach (string t in PizzaToppings)
      {
        Console.WriteLine(t);
      }
    }

    public decimal GetPrice()
    {
      double price = 0;
      if (Name == "Pepperoni")
      {
        price = 6.5;
      }
      else if (Name == "Meat")
      {
        price = 8.0;
      }
      else if (Name == "Hawaiian")
      {
        price = 7.5;
      }
      else if (Name == "New York")
      {
        price = 7.0;
      }

      if (Size == "Small") { }
      else if (Size == "Medium")
      {
        price += 0.5;
      }
      else if (Size == "Large")
      {
        price += 1.0;
      }

      return (Decimal)price;
    }
  }
}
