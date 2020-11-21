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
        int noOfWorkingdaysPerMonth = 20;
        int totalSalary = 0;
        int totalWorkDays = 0;
        int totalempHours = 0;
        int maximumHrsInMonth = 100;
      public int CheckEmployee()
        {
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);
            return employeeCheck;
        }
       public int GetEmpHrs()
        {
            int employeeCheck = CheckEmployee();
            return employeeCheck == IS_FULL_TIME ? FULL_TIME_EMP_HOURS :
                   employeeCheck == IS_PART_TIME ? PART_TIME_EMP_HOURS : ABSENT_EMP_HOURS;
        }
        public int CalculateWagePerMonth()
        {
            while (totalWorkDays < noOfWorkingdaysPerMonth && totalempHours < maximumHrsInMonth)
            {
                totalWorkDays++;
                totalempHours +=GetEmpHrs();
            }
            return totalSalary = DAILY_WAGE_PERHOUR * totalempHours;
        }
        
    }
}
