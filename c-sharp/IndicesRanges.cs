using System;

public partial class Koan
{
    public void IndicesAndRanges()
    {
        Console.WriteLine("Indices and Ranges");

        // Sample Array
        var animals = new string[] { "turtle", "fish", "cheetah", "baboon" };

        // List the animals in reverse
        for (var i = 1; i < animals.Length+1; i++)
        {
            // The ^ (hat) operator returns in index from the end of the array.
            Console.WriteLine(animals[^i]);
        }

    }
}