using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Order
  {
    public long OrderId { get; set; }
    public decimal Cost { get; set; }
    public DateTime OrderDate { get; set; }
    public Store Location { get; set; }
    public User User { get; set; }
    public List<Pizza> Pizzas { get; set; }

    public override string ToString()
    {
      return $"{"OrderId:"} {OrderId} {"Cost:"} {Cost} {"Location:"} {Location}";
    }

    public string GetLocation()
    {
      return $"{Location}";
    }
  }
}