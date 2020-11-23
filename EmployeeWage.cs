using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWage
    {
       public const int IS_FULL_TIME = 2;
       public const int IS_PART_TIME = 1;
       public const int DAILY_WAGE_PERHOUR = 20;
       public const int FULL_TIME_EMP_HOURS = 8;
       public const int PART_TIME_EMP_HOURS = 4;
       public const int ABSENT_EMP_HOURS = 0;
        int noOfWorkingdaysPerMonth = 20;
        int totalSalary = 0;
        int totalWorkDays = 0;
        int totalempHours = 0;
        int maximumHrsInMonth = 100;
        /// <summary>
        /// generating random number 0,1,2
        /// </summary>
        /// <returns></returns>
       
      public int CheckEmployee()
        {
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);
            return employeeCheck;
        }
        /// <summary>
        /// It is returning the empHrs of an employee on the basis of full time,part time
        /// </summary>
        /// <returns></returns>
       public int GetEmpHrs()
        {
            int employeeCheck = CheckEmployee();
            return employeeCheck == IS_FULL_TIME ? FULL_TIME_EMP_HOURS :
                   employeeCheck == IS_PART_TIME ? PART_TIME_EMP_HOURS : ABSENT_EMP_HOURS;
        }

        /// <summary>
        /// calculating the employeeWage per month
        /// </summary>
        /// <returns></returns>
        public int CalculateWagePerMonth(string company,int empRatePerHour,int noOfWorkingDays,int maximumHoursInMonth)
        {
            while (totalWorkDays < noOfWorkingDays && totalempHours < maximumHoursInMonth)
            {
                totalWorkDays++;
                totalempHours +=GetEmpHrs();
            }
            totalSalary = empRatePerHour * totalempHours;
            Console.WriteLine("Total empWage for a company" + company + "is:" +totalSalary);
            return totalSalary;
        }
        
    }
}
