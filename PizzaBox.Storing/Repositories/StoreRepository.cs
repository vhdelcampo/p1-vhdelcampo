using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storing.Databases;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{
  public class StoreRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Store> Get()
    {
      return _db.Store.ToList();
    }

    public Store Get(string id)
    {
      return _db.Store.SingleOrDefault(s => s.Location == id);
    }
  }
}