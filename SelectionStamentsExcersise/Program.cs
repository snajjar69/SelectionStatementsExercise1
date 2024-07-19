using System.Runtime.InteropServices.JavaScript;

namespace SelectionStatementsExcersise;

class Program
{
    static void Main(string[] args)
    {
        var r = new Random();
        var favNum = r.Next(1, 10);
        Console.WriteLine(favNum);
        
        var userInput = int.Parse(Console.ReadLine());
        
        if (userInput < favNum)
        {
            Console.WriteLine($"{userInput} is too low");
        }
        else if (userInput > favNum)
        {
            Console.WriteLine($"{userInput} is too high");
        }
        else
        {
            Console.WriteLine($"you guessed it");
        }
    }
}