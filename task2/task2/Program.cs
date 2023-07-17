using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { -3, 5, -7, 10, 0, 15, 7, -1, 11, -9, 2 };

        var positiveNumbersQuery = from num in numbers
                                   where num > 0 && num <= 11
                                   select num;

        List<int> positiveNumbers = positiveNumbersQuery.ToList();

        Console.Write("The numbers within the range of 1 to 11 are: ");
        foreach (int num in positiveNumbers)
        {
            Console.Write(num + " ");
        }
    }
}