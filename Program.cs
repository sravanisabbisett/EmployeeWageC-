using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employeeWage");
            EmployeeWage infosys = new EmployeeWage("infosys", 20, 20, 100);
            infosys.CalculateWagePerMonth();
            Console.WriteLine(infosys.toString());
            
            Console.ReadKey();
        }
    }
}
