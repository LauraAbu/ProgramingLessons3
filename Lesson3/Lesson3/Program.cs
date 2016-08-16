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
        {//if (8 % 3 == 2) dalybos modas.  turi buti gaunamas tik sveikasis skaicius. dalyba su nerodoma, nematoma liekana
            int[] dayinmonth=new[] {31,28,31,30,31,30,31,31,30,31,30,31};
            int years;
            int month;
            for (int i = 0; i < 100; i++) //begalinis ciklas for (;;)
            {
                Console.WriteLine("Please enter the year:");

                string input = Console.ReadLine();
//while (true) kad apskaičiuotu, kad reikia ivedus blogai menesi, neklaustu vėl metu. kartotu klausima tik ta kuri turi buti. 
                
                if (!int.TryParse(input, out years))
                {
                    Console.WriteLine("Invalid input. Please enter year number.");
                    continue;
                }
                if (years <1)
                {
                    Console.WriteLine("Invalid year. Please provide correct input.");
                    continue;
                }
                Month:
                Console.WriteLine("Please enter the month number (1:12)");

                input = Console.ReadLine();

                if (!int.TryParse(input, out month))
                {
                    Console.WriteLine("Invalid input. Please enter month number.");
                    goto Month;
                }
                if (month > 12 || month < 1)
                {
                    Console.WriteLine("There is only 12 months in a year. Please provide correct input.");
                    goto Month;
                }
                int totalDays=0;
                    for (int z = 0; z < 12; z++)
                {
                    if (month == z + 1)
                    {
                        totalDays = dayinmonth[z];
                        if (month == 2 & years % 4==0)
                        {
                            totalDays = 29;
                        }
                        break;
                    }
                }
                    //var totalDays = DateTime.DaysInMonth(years, month);// year turi būti

                    Console.WriteLine("{0:D4}-{1:D2} has {2} days", years,month, totalDays);

                    Console.WriteLine("Do you want to continue?");

                input = Console.ReadLine();

                if (input != "y")
                {
                    return;
                }
            }
        } //dali funkcionalumo iškelti i kita dali - kita pamoka----
    } //padaryti kad butu vidinis foras, kintamieji turi buti aiskus. kas saugoma jame. padaryti patiems algoritma, su ilgesniu apskaiciavimu. 
}
