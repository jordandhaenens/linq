using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }
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

            // Output how many numbers are in this list
            List<int> numbers1 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            // Console.WriteLine(numbers1.Count());

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            // Console.WriteLine("The sum of the purchases is {0}", purchases.Sum());

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            // Console.WriteLine(prices.Max());

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            var notSquared = wheresSquaredo.TakeWhile(n => (Math.Sqrt(n) % 1) != 0);
            // foreach (var num in notSquared) {
            //     Console.WriteLine(num);
            // }


            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var grouped = from cust in customers
                where cust.Balance >= 1000000
                group cust by cust.Bank into g
                select new {Bank = g.Key, custCount = g.Count()};
            // foreach (var item in grouped) {
            //     Console.WriteLine($"{item.Bank} has {item.custCount} customers");
            // }

            //Using fat arrows to accomplish the same thing
            // var newGroup = customers.Where(somebody => somebody.Balance >= 1000000)
            //     .GroupBy(cust => cust.Bank);
            // foreach (var item in newGroup) {
            //     Console.WriteLine($"{item.Key} has {item.Count()} customers");
            //     foreach (var cust in item) {
            //         Console.WriteLine($"{cust.Name}");
            //     }
            // }

            /*
                TASK:
                As in the previous exercise, you're going to output the millionaires,
                but you will also display the full name of the bank. You also need
                to sort the millionaires' names, ascending by their LAST name.

                Example output:
                    Tina Fey at Citibank
                    Joe Landy at Wells Fargo
                    Sarah Ng at First Tennessee
                    Les Paul at Wells Fargo
                    Peg Vale at Bank of America
            */
            List<Bank> banks = new List<Bank>() {
                new Bank(){ Name="First Tennessee", Symbol="FTB"},
                new Bank(){ Name="Wells Fargo", Symbol="WF"},
                new Bank(){ Name="Bank of America", Symbol="BOA"},
                new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            // Create some customers and store in a List
            List<Customer> SomeCustomers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var millionaireReport = from c in SomeCustomers
                where c.Balance >= 1000000
                join bank in banks on c.Bank equals bank.Symbol
                select new {c.Name, Bank = bank.Name};
            foreach (var person in millionaireReport) {
                Console.WriteLine($"{person.Name} at {person.Bank}");
            }

        }
    }
}
