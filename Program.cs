using System;

namespace EmployeeDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();

            var nameForSalaryPerMonth = PromptName();

            Console.WriteLine();

            PromptDepartmentNumber();

            Console.WriteLine();

            PromptYearlySalary(nameForSalaryPerMonth);

            Console.WriteLine();

        }
        static void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Our Employee Database    ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static string PromptName()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            return name;
        }
        static int PromptDepartmentNumber()
        {
            Console.WriteLine("What is your department number?");
            var DepartmentNumber = int.Parse(Console.ReadLine());
            return DepartmentNumber;
        }
        static void PromptYearlySalary(string nameForSalaryPerMonth)
        {
            Console.WriteLine("What is your yearly salary (in dollars)? ");
            var YearlySalaryInDollars = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var SalaryPerMonth = YearlySalaryInDollars / 12;
            Console.WriteLine($"Hello {nameForSalaryPerMonth}. You make {SalaryPerMonth} dollars per month.");

        }

    }

}