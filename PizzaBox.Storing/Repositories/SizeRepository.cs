using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storing.Databases;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{
  public class SizeRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<Size> Get()
    {
      return _db.Size.ToList();
    }

    public Size Get(string size)
    {
      return _db.Size.SingleOrDefault(s => s.Name == size);
    }
  }
}