using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            var LFruits = from fruit in fruits
                where fruit.StartsWith("L")
                select fruit;

            // foreach (string fruit in LFruits) {
            //     Console.WriteLine(fruit);
            // }


            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = new List<int>(from number in numbers
                where (number % 4 == 0) || (number % 6 == 0)
                select number
            );
            // foreach (int number in fourSixMultiples) {
            //     Console.WriteLine(number);
            // }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre" 
            };

            List<string> descend = new List<string>(from name in names
                orderby name descending
                select name
            );
            // foreach (string name in descend) {
            //     Console.WriteLine(name);
            // }

            // Build a collection of these numbers sorted in ascending order
            List<int> nums = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> ascendingNums = new List<int>(from number in nums
                orderby number ascending
                select number
            );
            // foreach (int number in ascendingNums) {
            //     Console.WriteLine(number);
            // }

            

        }
    }
}
