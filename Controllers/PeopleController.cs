using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using wealthKernelApp.Models;

namespace wealthKernelApp.Controllers
{
  public class PeopleController : Controller
  {
    // GET: people
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult ListPeople()
    {

      List<PersonModel> people = new List<PersonModel>();

      people.Add(new PersonModel { FirstName = "Tim", LastName = "Timson", Age = 10 });
      people.Add(new PersonModel { FirstName = "Jen", LastName = "Jenson", Age = 19 });
      people.Add(new PersonModel { FirstName = "John", LastName = "Jonhson", Age = 30 });

      return View();
    }

  }
}
