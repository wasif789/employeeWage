using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    interface IEmployeeWage
    {
        public void AddWage(string comp, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours);
        public void ComputeEmpWage();
    }
}
