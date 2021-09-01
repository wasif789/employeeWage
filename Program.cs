using System;

namespace empWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck==fullTime)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
