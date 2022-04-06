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
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int IS_ABSENT = 0;
            int EMP_RATE_PER_HOURS = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_PART_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 10;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage : {0}", empWage);

        }
    }
}
