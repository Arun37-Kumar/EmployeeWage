using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Employee Wage Problem");
            DailyWageCompute company1 = new DailyWageCompute();
            DailyWageCompute company2 = new DailyWageCompute();
            company1.EmployeeWageCalculations("Reliance",20,2,10);
            company2.EmployeeWageCalculations("DMart",20,4,10);
            Console.ReadLine();
        }
    }
}
