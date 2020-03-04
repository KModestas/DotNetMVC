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

      var entries = await client.GetEntriesByType<Lesson>("lesson");

      // foreach (var row in entries) Console.WriteLine(row.Slug);

      return View(entries);
    }

    public async Task<ActionResult> Lesson(string slug)
    {

      // slug is being passed in by the actionLink in /Lessons
      ViewData["slug"] = slug;

      var httpClient = new System.Net.Http.HttpClient();
      var client = new ContentfulClient(httpClient, "TJUTn86tuAZZ0L4Aw1LmA2HUBWNoU2TBHeCghBWJTac", "XsWxHVfA6Mu5yO2rlMf_IlrmIxfy5nAnFPraPg5LGc0", "dgv1c069l5im");

      // if you had the entry id you could just return the single entry without having to do a forEach in the view
      var entry = await client.GetEntries<Lesson>($"?content_type=lesson&fields.slug={slug}");

      // logs the total number of entries returned
      // Console.WriteLine(entries.Total.ToString());

      return View(entry);
    }

  }
}


