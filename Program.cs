using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        /*
            Start with a collection that is of type IEnumerable, which
            List is and initialize it with some values. This is the
            class sizes for a selection of NSS cohorts.
        */
        List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };

        /*
            Now we need to determine which cohorts fell within the range
            of acceptable size - between 20 and 26 students. Also, sort
            the new enumerable collection in ascending order.
        */
        IEnumerable<int> idealSizes = from count in cohortStudentCount
                                      where count < 27 && count > 19
                                      orderby count ascending
                                      select count;

        // Display each number that was the acceptable size
        foreach (int c in idealSizes)
        {
            Console.WriteLine($"{c}");
        }

        // .Max() finds the largest value in the list
        Console.WriteLine($"The Largest cohort was {cohortStudentCount.Max()}");

        //.Min finds the smallest value in the list
        Console.WriteLine($"The Largest cohort was {cohortStudentCount.Min()}");

        //Total all values in the list
        Console.WriteLine($"The total students from all cohorts {cohortStudentCount.Sum()}");

        //average of all values in list
        Console.WriteLine($"The average cohort size was {Math.Round(cohortStudentCount.Average(), 2)}");


        // Find the words in the collection that start with the letter 'L'

        List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };



         IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

        foreach (string f in LFruits)
        {
                Console.WriteLine($"L Fruit: {f}");
        }


    }

}