using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWage
    {
        int IS_PRESENT = 1;
      public string Checkemployee()
        {
            Random random = new Random();
            int employeeCheck = random.Next(0, 2);
            return employeeCheck == IS_PRESENT ? "Employee is Present" : "Employee is Absent";
        }
    }
}
