using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    private PizzaBoxRepository _pbr;

    public PizzaViewModel(PizzaBoxRepository repository)
    {
      _pbr = repository;
    }

    //public List<Topping> ToppingList { get; set; }
    //public List<Topping> Toppings { get; set; }

    public PizzaViewModel()
    {
      //ToppingList = _pbr.Read<Topping>().ToList();
    }
  }
}
