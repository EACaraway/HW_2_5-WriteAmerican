using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek2Problem5_method_w_American_format
{
    class Program
    {
        static void Main(string[] args)                                                  // Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
        {
            Console.Write("Enter day: ");
            string day = Console.ReadLine();
            Console.Write("Enter date: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            string month = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            WriteAmerican(day, month, date, year);                                      // Call method WriteAmerican in main.
        }
        static void WriteAmerican(string day, string month, int date, int year)         // Method that prints day, date, month and year in American format.
        {
            Console.WriteLine($"The current date is {day}, {month} {date}, {year}.");
        }
    }
}
