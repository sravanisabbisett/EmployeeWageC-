using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage1
{
    interface IComputeEmpWage
    {
       void addCompanyEmpwage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
       void computeEmpwage();
       int getTotalWage(string company);
    }
}
