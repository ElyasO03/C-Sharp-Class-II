using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Week1_Class
{
    internal class Program
    {
        static List<decimal> amounts = new List<decimal>();
        static List<string> categories = new List<string>();
        static List<DateTime> dates = new List<DateTime>();
        static void Main(string[] args)
        {

            WriteLine("1. Add Expense");
            WriteLine("2. View Summary");
            WriteLine("3. Search Expenses");
            WriteLine("4. Exit");
            Write("Which Option would like: ");

            switch(ReadLine())
            {
                case "1": 
                    // method call passing 3 arguments
                    AddExpense(); 
                    break;
                    case "2":
                        break;
                    case "3":
                    SearchExpenses();
                        break;

                    default:
                    WriteLine("Invalid Option!");
                    break;
            }// end switch

            ReadKey();
        }// end main

        static void AddExpense()
        {
            Write("Enter amount: ");
            if (decimal.TryParse(ReadLine(), out decimal amount))
            {
                Write("Please enter category: ");
                string category = ReadLine();

                Write("Enter date yyyy-mm-dd");
                if (DateTime.TryParse(ReadLine(), out DateTime date))
                {
                    amounts.Add(amount);
                    categories.Add(category);
                    dates.Add(date);
                    WriteLine("Expenses added");
                }
                else
                    WriteLine("Invalid Date");
            }// end if
            else
                WriteLine("Invalid Amount");
        }

        static void SearchExpenses() 
        {
            WriteLine("Enter a category to search: ");
            string searchCat = ReadLine();

            WriteLine("Expenses in the category Entered");

            foreach(var c in categories)
            {
                if(c.Equals(searchCat, StringComparison.OrdinalIgnoreCase))
                {
                    WriteLine($"Expense cat: {c}");
                }
            }
        }
    }
}
