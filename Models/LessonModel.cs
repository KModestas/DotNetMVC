using System;
namespace wealthKernelApp.Models
{
  public class Module
  {
    public string Title { get; set; }
    public string Copy { get; set; }
  }

  public class Lesson
  {
    public string Title { get; set; }
    public string Slug { get; set; }
    public Module[] Modules { get; set; }
  }

}