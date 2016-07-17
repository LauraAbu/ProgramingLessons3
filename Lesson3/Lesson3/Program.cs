using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int years;
            int month;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Please enter the year:");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out years))
                {
                    Console.WriteLine("Invalid input. Please enter number.");
                    continue;
                }
                if (years <1)
                {
                    Console.WriteLine("Invalid year. Please provide correct input.");
                    continue;
                }
                Console.WriteLine("Please enter the month number (1:12)");

                input = Console.ReadLine();

                if (!int.TryParse(input, out month))
                {
                    Console.WriteLine("Invalid input. Please enter number.");
                    continue;
                }
                if (month > 12 || month < 1)
                {
                    Console.WriteLine("There is only 12 months in a year. Please provide correct input.");
                    continue;
                }

                var totalDays = DateTime.DaysInMonth(years, month);

                Console.WriteLine("{0:D4}-{1:D2} has {2} days", years,month, totalDays);

                Console.WriteLine("Do you want to continue?");

                input = Console.ReadLine();

                if (input != "y")
                {
                    return;
                }
            }
        }
    }
}
