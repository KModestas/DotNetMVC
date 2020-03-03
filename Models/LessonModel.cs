using System;
namespace wealthKernelApp.Models
{
  public class LessonModel
  {
    public string Title { get; set; }
    public string Slug { get; set; }
    public wealthKernelApp.Models.ModuleModel[] Modules { get; set; }
  }

}