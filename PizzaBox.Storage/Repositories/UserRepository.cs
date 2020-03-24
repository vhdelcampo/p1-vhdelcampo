using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storage;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storage.Repositories
{
  public class UserRepository
  {
    private static PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public List<User> Get()
    {
      return _db.User.ToList();
    }
    public User Get(string username)
    {
      return _db.User.SingleOrDefault(u => u.Username == username);
    }
    public User GetPass(string password)
    {
      return _db.User.SingleOrDefault(u => u.Password == password);
    }
    public User Check(string username, string password)
    {
      return _db.User.Where(u => u.Username == username).SingleOrDefault(u => u.Password == password);
    }
    public bool Post(User user)
    {
      _db.User.Add(user);
      return _db.SaveChanges() == 1;
    }
    public bool Put(User user)
    {
      User u = Get(user.Username);

      u = user;
      return _db.SaveChanges() == 1;
    }
    public object CheckAccount(string user, string pass)
    {
      return new object();
    }
  }
}