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
            EmpWageBuilder Infosys = new EmpWageBuilder("Infosys",20,2,10);
            EmpWageBuilder Reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            Infosys.ComputeWage();
            Console.WriteLine(Infosys.toString());
            Reliance.ComputeWage();
            Console.WriteLine(Reliance.toString());
            Console.ReadLine();
        }
    }
}
