using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storing.Databases;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{
  public class UserRepository
  {
    private readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public User Get(string id)
    {
      return _db.User.SingleOrDefault(u => u.UserId == id);
    }
    public User Check(string userId, string password)
    {
      return _db.User.Where(u => u.UserId == userId).SingleOrDefault(u => u.Password == password);
    }
  }
}