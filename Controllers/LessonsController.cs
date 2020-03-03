using System;
using System.Collections.Generic;
// Task needs to be imported when using async actions
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wealthKernelApp.Models;
using Contentful.Core;

using Contentful.AspNetCore;
using Contentful.Core.Models.Management;

namespace wealthKernelApp.Controllers
{
  public class LessonsController : Controller
  {
    // When you go to /Lessons, return a list of all lessons
    public async Task<ActionResult> Index()
    {

      //   declare a list for lessons 
      //   List<Lesson> lessons = new List<Lesson>();       

      var httpClient = new System.Net.Http.HttpClient();
      var _client = new ContentfulClient(httpClient, "TJUTn86tuAZZ0L4Aw1LmA2HUBWNoU2TBHeCghBWJTac", "XsWxHVfA6Mu5yO2rlMf_IlrmIxfy5nAnFPraPg5LGc0", "dgv1c069l5im");

      //   var entries = await client.GetEntries<dynamic>();
      //   var entry = await client.GetEntry<Lesson>("lesson");
      var contentType = await _client.GetContentType("lesson");

      var entries = await _client.GetEntriesByType<Lesson>("lesson");

      return View(entries);

      //   return View(staticLessons);
    }

  }
}


// // create a list of lessons containing modules 
// var staticLessons = new Lesson[]
// {
//     new Lesson
//     {
//         Title = "Serve localized content",
//         Slug = "serve-localized-content",
//         Modules = new Module[]
//         {
//             new Module
//             {
//                 Title = "Serve localized content > fetching",
//                 Copy = "If you have configured different locales within your content model, you can fetch that localized content:"
//             },
//             new Module
//             {
//                 Title = "Serve localized content > fetch code",
//                 Copy = "var queryBuilder = QueryBuilder<dynamic>.New.LocaleIs(\"de-DE\");\nvar entries = await client.GetEntriesAsync(queryBuilder);\nConsole.WriteLine(entries.ToString());"
//             },
//             new Module
//             {
//                 Title = "Serve localized content > code success",
//                 Copy = "Switch the language of this text from English to German by going to `Locale: U.S. English` in the top menu bar and selecting `German`."
//             }
//         }
//     },
//     new Lesson
//     {
//         Title = "Content management",
//         Slug = "content-management",
//         Modules = new Module[]
//         {
//             new Module
//             {
//                 Title = "Content management > copy 1",
//                 Copy = "A basic Contentful setup consists of a client application reading content, this example app for instance, and another application that is writing content, like the Contentful web app. The client application is reading content by connecting to the Content Delivery API. The Contentful web app, on the other hand, is writing content by connecting to the Content Mangement API.\n\nThe Contentful web app is a single page application created by Contentful and assists with common content management tasks."
//             },
//             new Module
//             {
//                 Title = "Content management > copy 2",
//                 Copy = "As mentioned, the Contentful web app is a client that uses the Content Management API. Therefore, you could replicate the functionality that the Contentful web app provides by making an API call. This is a powerful aspect of an API-first design because it helps you to connect Contentful to third-party systems."
//             }
//         }
//     }
// };
