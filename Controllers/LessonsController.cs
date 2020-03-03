using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using wealthKernelApp.Models;

namespace wealthKernelApp.Controllers
{
  public class LessonsController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

  }
}
