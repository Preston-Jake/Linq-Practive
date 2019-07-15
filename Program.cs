using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {
                 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                 };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

            fourSixMultiples.ToList().ForEach(num => Console.WriteLine(num));

            Console.WriteLine("---------------------");

            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var namesSortedByDesending = from name in names
                                         orderby name ascending
                                         select name;
            foreach (var name in namesSortedByDesending)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------");
            // Build a collection of these numbers sorted in ascending order
            List<int> newNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var numbersSortedByAsending = from num in newNumbers
                                          orderby num ascending
                                          select num;

            foreach (var num in numbersSortedByAsending)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("--------------------");

            List<int> newNewnumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var count = newNewnumbers.Count();

            Console.WriteLine(count);

            Console.WriteLine("----------------");

            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var totalAmount = purchases.Sum();

            Console.WriteLine(totalAmount);

            Console.WriteLine("---------------------");

            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var mostExpensive = prices.Max();

            Console.WriteLine(mostExpensive);

            Console.WriteLine("---------------------");

            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            var perfectSquare = wheresSquaredo.TakeWhile(number =>
            {
                var num = Convert.ToInt32(Math.Sqrt(number));
                return num * num != number;
            });

            foreach (var num in perfectSquare)
            {
                Console.WriteLine(num);
            }

            List<Customer> customers = new List<Customer>()
            {
            new Customer() { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
            new Customer() { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
            new Customer() { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
            new Customer() { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
            new Customer() { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
            new Customer() { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
            new Customer() { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
            new Customer() { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
            new Customer() { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
            new Customer() { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };

            var millionaries = customers.Where(customer => customer.Balance >= 1000000);

            var Banks = millionaries.GroupBy(customer => customer.Bank);
            Console.WriteLine("-------------------------");
            foreach (var mil in Banks)
            {
                Console.WriteLine(mil);
                Console.WriteLine($"{mil.Key} {mil.Count()}");
            }


        }
    }
}
