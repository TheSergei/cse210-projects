using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userInput = int.Parse(Console.ReadLine());

        List<int> numbersList = new List<int>();

        while (userInput > 0)
        {       
            Console.WriteLine("Enter a number:");
            int addedNumber = int.Parse(Console.ReadLine());

            numbersList.Add(userInput);

            int listSum = numbersList.Sum();

        if (addedNumber == 0)
        {
            Console.WriteLine($"the sum is {listSum}");
        }
        }
            


        
    }
}