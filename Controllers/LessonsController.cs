using System;
// Task needs to be imported when using async actions
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wealthKernelApp.Models;
using Contentful.Core;

namespace wealthKernelApp.Controllers
{
  public class LessonsController : Controller
  {
    // When you go to /Lessons, return a list of all lessons
    public async Task<ActionResult> Index()
    {
      var httpClient = new System.Net.Http.HttpClient();
      var client = new ContentfulClient(httpClient, "TJUTn86tuAZZ0L4Aw1LmA2HUBWNoU2TBHeCghBWJTac", "XsWxHVfA6Mu5yO2rlMf_IlrmIxfy5nAnFPraPg5LGc0", "dgv1c069l5im");


      var contentType = await client.GetContentType("lesson");

      var entries = await client.GetEntriesByType<Lesson>("lesson");

      return View(entries);
    }

  }
}


