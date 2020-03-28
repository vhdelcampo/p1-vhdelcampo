using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storing.Databases;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaTypeRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<PizzaType> Get()
    {
      return _db.PizzaType.ToList();
    }

    public PizzaType Get(string pizzaT)
    {
      return _db.PizzaType.SingleOrDefault(pt => pt.Name == pizzaT);
    }
  }
}