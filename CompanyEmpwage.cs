using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class CompanyEmpwage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpwage;

        public CompanyEmpwage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpwage)
        {
            this.totalEmpwage = totalEmpwage;
        }
        public string toString()
        {
            return "Total Emp wage for company:" + this.company + "is:" + this.totalEmpwage;
        }
    }
}