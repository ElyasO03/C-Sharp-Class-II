using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week2HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sales salesEmployee = new Sales(1, "John", "Doe", new DateTime(2023, 1, 1), 1000, 0.1, 5000);
            WriteLine($"Sales Employee Pay: {salesEmployee.Pay}");

            Salary salaryEmployee = new Salary(2, "Jane", "Smith", new DateTime(2022, 12, 1), 5000, 100);
            WriteLine($"Salary Employee Pay: {salaryEmployee.Pay}");

            Hourly hourlyEmployee = new Hourly(3, "Bob", "Johnson", new DateTime(2023, 2, 15), 45, 20);
            WriteLine($"Hourly Employee Pay: {hourlyEmployee.Pay}");

            ReadKey();
        }//ends main
    }
}
