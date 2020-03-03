using System;
namespace wealthKernelApp.Models
{
  public class Lesson
  {
    public string Title { get; set; }
    public string Slug { get; set; }
    public wealthKernelApp.Models.Module[] Modules { get; set; }
  }

}