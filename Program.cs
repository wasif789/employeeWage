using System;

namespace empWage
{
    class Program
    {
        public const int empWage_perhour = 20;
        public const int part_time = 1;
        public const int full_time = 2;
        public const int num_working_days = 20;
        public const int maxworkinghour = 100;
        static void Main(string[] args)
        {
            int empHrs, totalEmpHours = 0;
            int empWage, totalEmployeeWage = 0, totalWorkingdays = 0;
            for (int day = 0; totalEmpHours<=maxworkinghour && totalWorkingdays<num_working_days;day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case part_time:
                        empHrs = 4;
                        break;
                    case full_time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHours += empHrs;
                Console.WriteLine("days:" + totalWorkingdays + "employee hours:" + empHrs);
            }
            totalEmployeeWage = totalEmpHours * empWage_perhour;
            Console.WriteLine("total employee wage:" + totalEmployeeWage);
        }
    }
}
