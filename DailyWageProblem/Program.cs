﻿using System;
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
            DailyWageCompute checkPresent = new DailyWageCompute();
            checkPresent.isPresent();
            Console.ReadLine();
        }
    }
}
