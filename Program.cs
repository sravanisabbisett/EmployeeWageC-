using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employeeWage");
            EmployeeWage employeeWage = new EmployeeWage();
            String result = employeeWage.Checkemployee();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
