using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    public long UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }
    public List<Order> Orders { get; set; }

    public User()
    {
      UserId = DateTime.Now.Ticks;
    }
  }
}