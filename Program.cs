using System;

namespace empWage
{
    class EmployeeWage : IEmployeeWage
    {
        //initialzing constants
        public const int FULL_TIME = 1;
        public const int ABSENT = 0;
        public const int PART_TIME = 2;

        private int noOfCompanies = 0;
        private CompanyEmpWage[] CompanyEmpArray;

        public EmployeeWage()
        {
            this.CompanyEmpArray = new CompanyEmpWage[5];
        }

        public void AddWage(string comp, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            CompanyEmpArray[this.noOfCompanies++] = new CompanyEmpWage(comp, wagePerHour, workingDaysPerMonth, maxWorkingHours);
        }

        //method for compute wage
        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompanies; i++)
            {
                CompanyEmpArray[i].SetWagesForMonth(this.CalculateEmpWage(this.CompanyEmpArray[i]));
                Console.WriteLine(this.CompanyEmpArray[i].toString());
            }
        }
        private int CalculateEmpWage(CompanyEmpWage company)
        {
            int workingDays = 0;

            int workingHours = 0;
            int totalWorkingHours = 0;

            Random rand = new Random(); // intializing random class
            //for loop for calculating for 20 days
            while (totalWorkingHours <= company.maxWorkingHours && workingDays < company.workingDaysPerMonth)
            {
                int empInput = rand.Next(0, 3);//Generating random b/w 0 and 3
                switch (empInput)
                {
                    case FULL_TIME:
                        //Console.WriteLine("Employee is Present Full Time");
                        workingHours = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("Employee is Present Part Time");
                        workingHours = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee is Absent");
                        workingHours = 0;
                        break;
                }
                totalWorkingHours += workingHours;
                workingDays++;

            }

            return company.wagePerHour * totalWorkingHours;//formula for wages
            //Console.WriteLine($"Total EmpWage For company {company} is {wagesForMonth}");

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmployeeWage emp = new EmployeeWage();
            emp.AddWage("Tvs", 50, 20, 100);
            emp.AddWage("Zoho", 40, 20, 200);
            emp.ComputeEmpWage();
        }
    }
}
    

