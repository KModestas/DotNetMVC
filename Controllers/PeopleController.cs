using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using wealthKernelApp.Models;

namespace wealthKernelApp.Controllers
{
  public class PeopleController : Controller
  {
    // GET: people
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult ListPeople()
    {
      // create a list of people 
      List<PersonModel> people = new List<PersonModel>();

      // add new people to list
      people.Add(new PersonModel { FirstName = "Tim", LastName = "Timson", Age = 10 });
      people.Add(new PersonModel { FirstName = "Jen", LastName = "Jenson", Age = 19 });
      people.Add(new PersonModel { FirstName = "John", LastName = "Jonhson", Age = 30 });

      Console.WriteLine("PEOPLE ", people);

      // pass list of people data to the people view
      // generally you would only pass in a model or list of model as data to the view
      return View(people);
    }

  }
}
