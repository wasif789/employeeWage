using System;
using System.Collections.Generic;
using System.Text;

namespace empWage
{
    class CompanyEmpWage
    {
        //instance variables
        public string company;
        public int wagePerHour;
        public int workingDaysPerMonth;
        public int maxWorkingHours;
        public int wagesForMonth;

        // parameterized constructor for this class
        public CompanyEmpWage(string comp, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            this.company = comp;
            this.wagePerHour = wagePerHour;
            this.workingDaysPerMonth = workingDaysPerMonth;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void SetWagesForMonth(int swfm)
        {
            this.wagesForMonth = swfm;
        }
        public string toString()
        {
            return $"Total EmpWage For company {this.company} is {this.wagesForMonth}";
        }
    }
}


