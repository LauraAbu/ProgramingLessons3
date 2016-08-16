using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee user1 = new Employee();
            user1.FirstName = "Jonas";
            user1.LastName = "Petrukonis";
            user1.Adress = "Ateities g. 1-15";
            user1.Age = 25;
            user1.IdNumber = 44558877887;
            user1.Shift = 0.25m;
            user1.Manager = "Mantas";
            user1.StartDate = new DateTime(2016,01,05);
            user1.SalaryBrutto = 1000;

            ShowEmployee(user1);

            Employee user2 = new Employee();
            user2.FirstName = "Petras";
            user2.LastName = "Petraitis";
            user2.Adress = "Zemaites g. 29-7";
            user2.Age = 18;
            user2.IdNumber = 44454548877887;
            user2.Shift = 1m;
            user2.Manager = "Kestas";
            user2.StartDate = new DateTime(2016, 12, 05);
            user2.SalaryBrutto = 1500;

            ShowEmployee(user2);

            Employee user3 = new Employee();
            user3.FirstName = "Antanas";
            user3.LastName = "Jablonskis";
            user3.Adress = "Gedimono pr. 92-12";
            user3.Age = 29;
            user3.IdNumber = 456655884488;
            user3.Shift = 1m;
            user3.Manager = "Mindaugas";
            user3.StartDate = new DateTime(2014, 04, 05);
            user3.SalaryBrutto = 1890;

            ShowEmployee(user3);

            Employee user4 = new Employee();
            user4.FirstName = "Tomas";
            user4.LastName = "Kuliesius";
            user4.Adress = "Kalvariju g. 115-33";
            user4.Age = 30;
            user4.IdNumber = 445589854237;
            user4.Shift = 1.5m;
            user4.Manager = "Mantas";
            user4.StartDate = new DateTime(2013, 08, 05);
            user4.SalaryBrutto = 2150;

            ShowEmployee(user4);

            Employee user5 = new Employee();
            user5.FirstName = "Benas";
            user5.LastName = "Jakubauskas";
            user5.Adress = "Amerikos g. 15";
            user5.Age = 24;
            user5.IdNumber = 44245877887;
            user5.Shift = 1m;
            user5.Manager = "Tomas";
            user5.StartDate = new DateTime(2016, 07, 25);
            user5.SalaryBrutto = 800;

            ShowEmployee(user5);

            Console.ReadLine();


        }

        static void ShowEmployee(Employee employee)
        {
            employee.CalculateSalary();

            Console.WriteLine("--------------EMPLOYEE----------------");
            Console.WriteLine("Personal info");
            Console.WriteLine("{0} {1}, Age: {2}, ID {3}", employee.FirstName, employee.LastName, employee.Age, employee.IdNumber);
            Console.WriteLine("Address {0}", employee.Adress);
            Console.WriteLine("StartDate {0}, Shift {1}, Manager {2}", employee.StartDate,employee.Shift, employee.Manager);
            Console.WriteLine("SalaryBrutto {0}, SalaryNetto {1}", employee.SalaryBrutto, employee.SalaryNetto);
        }

    }
}
