using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmployeeWage
    {
       public const int IS_FULL_TIME = 2;
       public const int IS_PART_TIME = 1;
       public const int FULL_TIME_EMP_HOURS = 8;
       public const int PART_TIME_EMP_HOURS = 4;
       public const int ABSENT_EMP_HOURS = 0;
       int totalSalary = 0;
       int totalWorkDays = 0;
       int totalempHours = 0;
       private int noOfCompany = 0;
       private CompanyEmpwage[] companyEmpWageArray;
       
        public EmployeeWage()
        {
            this.companyEmpWageArray = new CompanyEmpwage[5];
        }

        public void addCompanyEmpwage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            companyEmpWageArray[this.noOfCompany] = new CompanyEmpwage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            noOfCompany++;
        }
        
        public void computeEmpwage()
        {
            for(int i = 0; i < noOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpwage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        
        
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
        /// 
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="noOfWorkingDays"></param>
        /// <param name="maximumHoursInMonth"></param>
        /// <returns></returns>
        public int computeEmpwage(CompanyEmpwage companyEmpwage)
        {
            while (totalWorkDays < companyEmpwage.numOfWorkingDays && totalempHours < companyEmpwage.maxHoursPerMonth)
            {
                totalWorkDays++;
                totalempHours +=GetEmpHrs();
                Console.WriteLine("Day#:" + totalWorkDays + "Emp hrs" + GetEmpHrs());
            }
            totalSalary = companyEmpwage.empRatePerHour * totalempHours;
            return totalSalary;
        }

    }
}
