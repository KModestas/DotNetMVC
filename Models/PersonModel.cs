
namespace wealthKernelApp.Models
{
  public class PersonModel
  {
    // properties of the class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    // = true is a default value
    public bool IsAlive { get; set; } = true;
  }
}