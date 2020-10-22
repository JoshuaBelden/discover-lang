using System;
using System.Linq;

public partial class Koan
{
    public void FizzBuzz()
    {
        Console.WriteLine("Staring FizzBuzz!");
        foreach(var idx in Enumerable.Range(1, 100))
        {
            switch (idx)
            {
                case int x when x % 3 == 0:
                    Console.Write("Fizz");
                    break;
                case int x when x % 5 == 0:
                    Console.Write("Buzz");
                    break;
                default:
                    Console.Write(idx);
                    break;
            }
            Console.Write(Environment.NewLine);
        }
    }
}