using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWageProblem
{
    internal class DailyWageCompute
    {
        public void isPresent()
        {
            int IS_PRESENT = 1;
            int IS_ABSENT = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
