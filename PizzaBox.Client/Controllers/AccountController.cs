using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  public class AccountController : Controller
  {
    private UserRepository _ur;
    private ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(AccountViewModel account)
    {
      if (ModelState.IsValid)
      {
        var acct = _ur.CheckAccount(account.Username, account.Password);

        if (acct != null)
        {
          if (account.User)
          {
            return View("User", acct);
          }

          return View("Store", acct);
        }
      }

      return View(account);
    }

    public IActionResult Logout()
    {
      return View();
    }
  }
}
