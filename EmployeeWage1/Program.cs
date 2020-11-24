using System;

namespace EmployeeWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employeeWage");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.addCompanyEmpwage("infosys", 20, 20, 100);
            employeeWage.addCompanyEmpwage("Dmart", 20, 25, 100);
            employeeWage.computeEmpwage();
            Console.WriteLine("Total EmpWage for infosys company:" + employeeWage.getTotalWage("infosys"));
            Console.WriteLine("Total EmpWage for infosys company:" + employeeWage.getTotalWage("Dmart"));
            Console.ReadKey();
        }
    }
}
