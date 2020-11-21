using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWage
    {
        int IS_PRESENT = 1;
        int DAILY_WAGE_PERHOUR = 20;
        int EMP_HOURS = 8;
        int ABSENT_EMP_HOURS = 0;
      public int CheckEmployee()
        {
            Random random = new Random();
            int employeeCheck = random.Next(0, 2);
            return employeeCheck;
        }
       public int CalculateWage()
        {
            int employeeCheck = CheckEmployee();
            return employeeCheck == IS_PRESENT ? DAILY_WAGE_PERHOUR * EMP_HOURS :
                                                DAILY_WAGE_PERHOUR * ABSENT_EMP_HOURS;
        }
    }
}
