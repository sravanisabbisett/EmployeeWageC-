using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employeeWage");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.CalculateWagePerMonth("infosys", 20, 20, 100);
            employeeWage.CalculateWagePerMonth("wipro", 20, 25, 100);
            Console.ReadKey();
        }
    }
}
