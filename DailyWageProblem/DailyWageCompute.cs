﻿using System;
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
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int IS_ABSENT = 0;
            const int EMP_RATE_PER_HOURS = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 8;
                    break;

                case IS_FULL_TIME:
                    empHrs = 10;
                    break;
                case IS_ABSENT:
                    empHrs = 0;
                    break;
                default:
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage : {0}", empWage);

        }
    }
}
