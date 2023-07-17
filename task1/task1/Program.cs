using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Enumerable.Range(0, 10).ToList();

        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        List<int> evenNumbers = evenNumbersQuery.ToList();

        Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are:");
        foreach (int num in evenNumbers)
        {
            Console.Write(num + " ");
        }
    }
}