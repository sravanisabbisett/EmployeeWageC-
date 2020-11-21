using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employeeWage");
            EmployeeWage employeeWage = new EmployeeWage();
            int result = employeeWage.CalculateWage();
            Console.WriteLine("Daily Wage:::"+result);
            Console.ReadKey();
        }
    }
}
