using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Employee
    {
        //vardas, pavarde, asmens kodas, amzius, adresas, etatas, darbo pradzios data, alga pries mokescius ir vadovas. 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdNumber { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public decimal Shift { get; set; }
        public DateTime StartDate { get; set; }
        public decimal SalaryBrutto { get; set; }
        public decimal SalaryNetto { get; private set; }
        public string Manager { get; set; }

        public void CalculateSalary()//Metodas apskaiciuojamas Netto atlyginima
        {//m - decimal trumpinys
            SalaryNetto = SalaryBrutto - ((SalaryBrutto * 0.15m) + (SalaryBrutto * 0.06m) + (SalaryBrutto * 0.03m));

        }
    }
}
