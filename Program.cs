using System;

namespace empWage
{
    class EmployeeWage
    {
        //initialzing constants
        public const int FULL_TIME = 1;
        public const int ABSENT = 0;
        public const int PART_TIME = 2;
        //public const int WAGE_PER_HOUR = 20;
        //public const int WORKING_DAYS_PER_MONTH = 20;
        //public const int WORKING_HOURS_PER_MONTH = 100;
        private string company;
        private int wagePerHour;
        private int workingDaysPerMonth;
        private int maxWorkingHours;
        private int wagesForMonth;

        public EmployeeWage(string comp, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            this.company = comp;
            this.wagePerHour = wagePerHour;
            this.workingDaysPerMonth = workingDaysPerMonth;
            this.maxWorkingHours = maxWorkingHours;
        }
        private void CalculateEmpWage()
        {
            int workingDays = 0;

            int workingHours = 0;
            int totalWorkingHours = 0;

            Random rand = new Random(); // intializing random class
            //for loop for calculating for 20 days
            while (totalWorkingHours <= this.maxWorkingHours && workingDays < this.workingDaysPerMonth)
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

            this.wagesForMonth = this.wagePerHour * totalWorkingHours;//formula for wages
            //Console.WriteLine($"Total EmpWage For company {company} is {wagesForMonth}");

        }
        public string toString()
        {
            return $"Total EmpWage For company {this.company} is {this.wagesForMonth}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //parameterized constructor for employee wage class to initialize tvs variables
            EmployeeWage tvs = new EmployeeWage("Tvs", 50, 20, 100);
            tvs.CalculateEmpWage();
            Console.WriteLine(tvs.toString());
            //parameterized constructor for employee wage class to initialize zoho variables
            EmployeeWage zoho = new EmployeeWage("Zoho", 40, 20, 200);
            zoho.CalculateEmpWage();
            Console.WriteLine(zoho.toString());

            //CalculateEmpWage("Tvs",50,20,100);
            //CalculateEmpWage("Zoho", 40, 20, 200);

        }
    }
}
