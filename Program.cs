using System;

namespace learningCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      //excercise 1
      //   Console.WriteLine("What is your name?");
      //   var name = Console.ReadLine();
      //   Console.WriteLine("How old are you?");
      //   var age = Console.ReadLine();
      //   Console.WriteLine("In what month were you born?");
      //   var month = Console.ReadLine();
      //   Console.WriteLine($"Name: {name}");
      //   Console.WriteLine($"Age: {age}");
      //   Console.WriteLine($"Month: {month}");
      //excercise 2/3
      //   var password = "";
      //   while (password != "password")
      //   {
      //     Console.WriteLine("Enter your password: ");
      //     password = Console.ReadLine();
      //   }
      //   Console.WriteLine("Logged In.");
      //excercise 4
      //   for (var i = 0; i <= 5; i++)
      //   {
      //     for (var j = 1; j <= 10; j++)
      //     {
      //       Console.WriteLine(j);
      //     }
      //     for (var k = 10; k > 0; k--)
      //     {
      //       Console.WriteLine(k);
      //     }
      //   }
      var grades = new int[] { 77, 66, 88, 90, 45, 10 };

      foreach (var grade in grades)
      {
        Console.WriteLine(grade);
      }

    }
  }
}