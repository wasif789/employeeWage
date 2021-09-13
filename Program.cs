using System;

namespace empWage
{
    class Program
    {
        //initialzing constants
        public const int FULL_TIME = 1;
        public const int ABSENT = 0;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int WORKING_DAYS_PER_MONTH = 20;
        public const int WORKING_HOURS_PER_MONTH = 100;


        private static void CalculateEmpWage()
        {
            int workingDays = 0;
            int wagesForMonth = 0;
            int workingHours = 0;
            int totalWorkingHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            Random rand = new Random(); // intializing random class
            //for loop for calculating for 20 days
            while (totalWorkingHours <= WORKING_HOURS_PER_MONTH && workingDays < WORKING_DAYS_PER_MONTH)
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

            wagesForMonth = WAGE_PER_HOUR * totalWorkingHours;//formula for wages
            Console.WriteLine("Employee wage per month is " + wagesForMonth);

        }

        static void Main(string[] args)
        {
            CalculateEmpWage();

        }
    }
}
