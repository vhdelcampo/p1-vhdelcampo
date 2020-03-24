using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Store> Store { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=pizzaboxdb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pizza>().HasKey(p => p.PizzaId);
      builder.Entity<Order>().HasKey(o => o.OrderId);
      builder.Entity<User>().HasKey(u => u.UserId);
      builder.Entity<Store>().HasKey(s => s.Location);

      builder.Entity<Order>().HasMany(o => o.Pizzas).WithOne(p => p.Order);
      builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
      builder.Entity<Store>().HasMany(s => s.Orders).WithOne(o => o.Location);

      builder.Entity<User>().HasData(new User[]
      {
        new User() { Username = "roby", Password = "pass", UserType = "Customer"},
        new User() { Username = "isaiah", Password = "pass", UserType = "Customer"},
        new User() { Username = "victor", Password = "pass", UserType = "Admin"},
      });

      builder.Entity<Store>().HasData(new Store[]
      {
        new Store() { Location = "S Cooper St"},
        new Store() { Location = "S West St"},
      });
    }

  }
}
