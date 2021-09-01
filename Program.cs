using System;

namespace empWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int partTime = 1;
            int fullTime = 2;
            int empWage_perhour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck==partTime)
            {
                empHrs = 4;
            }
            else if(empCheck==fullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empWage_perhour * empHrs;
            Console.WriteLine("employee wage:" + empWage);
        }
    }
}
