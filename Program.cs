using System;

namespace empWage
{
    class Program
    {

        static void Main(string[] args)
        {
            int empWage_perhour = 20;
            int part_time = 1;
            int full_time = 2;
            int empHrs;
            int empWage;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case part_time:
                    empHrs= 4;
                    break;
                case full_time:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empWage_perhour * empHrs;
            Console.WriteLine("employee wage:" + empWage);
        }
    }
}
