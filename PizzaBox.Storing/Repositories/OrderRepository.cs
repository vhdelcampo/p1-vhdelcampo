using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storing.Databases;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Interfaces;
using System;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

    public Order Get(long id)
    {
      return _db.Order.SingleOrDefault(o => o.OrderId == id);
    }

    public bool Update(Order order)
    {
      _db.Order.Add(order);
      return _db.SaveChanges() == 1;
    }
  }
}