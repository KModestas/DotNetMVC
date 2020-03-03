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
      // declare a list for people 
      List<PersonModel> people = new List<PersonModel>();

      // add new people to list (I assume you would make a request for data to the db in a real app)
      people.Add(new PersonModel { FirstName = "Tim", LastName = "Timson", Age = 10 });
      people.Add(new PersonModel { FirstName = "Jen", LastName = "Jenson", Age = 19 });
      people.Add(new PersonModel { FirstName = "John", LastName = "Jonhson", Age = 30 });

      // if you wanted to console.write each persons firstname you could:
      // people.ForEach(person => Console.Write("{0}\t", person.FirstName));

      // pass list of people data to the people view
      // generally you would only pass in a model or list of model as data to the view
      return View(people);
    }

  }
}
