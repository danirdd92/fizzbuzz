using System;

namespace fizzbuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      DisplayFizzBuzz(5, 2, 200);
      Console.ReadKey();
    }

    static void DisplayFizzBuzz(int num = 3, int multiplayer = 5, int count = 100)
    {
      for (int i = 0; i < count; i++)
        Console.WriteLine(GetOutputNumber(i, num, multiplayer));
    }

    static string GetOutputNumber(int i, int num, int multiplayer) =>
     (i % num == 0, i % multiplayer == 0) switch
     {
       (true, true) => "FizzBuzz",
       (true, _) => "Fizz",
       (_, true) => "Buzz",
       _ => i.ToString()
     };

  }
}
