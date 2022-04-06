using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWageProblem
{
    internal class DailyWageCompute
    {
        public void EmployeeWageCalculations()
        {
            int IS_PRESENT = 1;
            int IS_ABSENT = 0;
            int EMP_RATE_PER_HOURS = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present.");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage : {0}", empWage);

        }
    }
}
