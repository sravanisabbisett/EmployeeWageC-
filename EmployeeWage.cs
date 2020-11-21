using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWage
    {
        int IS_FULL_TIME = 2;
        int IS_PART_TIME = 1;
        int DAILY_WAGE_PERHOUR = 20;
        int FULL_TIME_EMP_HOURS = 8;
        int PART_TIME_EMP_HOURS = 4;
        int ABSENT_EMP_HOURS = 0;
      public int CheckEmployee()
        {
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);
            return employeeCheck;
        }
       public int CalculateWage()
        {
            int employeeCheck = CheckEmployee();
            return employeeCheck == IS_FULL_TIME ? DAILY_WAGE_PERHOUR * FULL_TIME_EMP_HOURS :
                   employeeCheck == IS_PART_TIME ? DAILY_WAGE_PERHOUR * PART_TIME_EMP_HOURS :
                                     DAILY_WAGE_PERHOUR * ABSENT_EMP_HOURS;
        }

    }
}
