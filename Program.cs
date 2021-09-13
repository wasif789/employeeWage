using System;
using System.Collections;

namespace empWage
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmployeeWage emp = new EmployeeWage();
            emp.AddWage("Tvs", 50, 20, 100);
            emp.AddWage("Zoho", 40, 20, 200);
            emp.ComputeEmpWage();
            Console.WriteLine($"Total wage for Tvs Comapany: {emp.GetTotalWage("Tvs")}");
            Console.WriteLine($"Total wage for Zoho Comapany: {emp.GetTotalWage("Zoho")}");
        }
    }
}

    

