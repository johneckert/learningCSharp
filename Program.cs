using System;

namespace learningCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is your name?");
      var name = Console.ReadLine();
      Console.WriteLine("How old are you?");
      var age = Console.ReadLine();
      Console.WriteLine("In what month were you born?");
      var month = Console.ReadLine();
      Console.WriteLine($"Name: {name}");
      Console.WriteLine($"Age: {age}");
      Console.WriteLine($"Month: {month}");
    }
  }
}