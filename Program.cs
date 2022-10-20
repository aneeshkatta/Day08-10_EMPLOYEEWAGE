using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usercase08EmployeeWage
{
    internal class Program
    {
        const int IS_Parttime = 0;
        const int IS_Fulltime = 1;


        public static int ComputeWage(string Company, int EMP_RATE_PER_HOUR, int NUM_OF_WorkingDays, int MAX_HRS_PER_MONTH)

        {
            int emphrs = 0;
            int totalemphrsinmonth = 0;
            int totalworkingdays = 0;
            while (totalemphrsinmonth < MAX_HRS_PER_MONTH && totalworkingdays < NUM_OF_WorkingDays)
            {
                totalworkingdays++;

                Random random = new Random();
                int empCheck = random.Next(0, 2);

                switch (empCheck)
                {
                    case IS_Parttime:
                        emphrs = 4;
                        break;

                    case IS_Fulltime:
                        emphrs = 8;
                        break;

                    default:
                        emphrs = 0;
                        break;
                }

                totalemphrsinmonth += emphrs;
                Console.WriteLine(" Days #: " + totalworkingdays + "\n   Employee hrs is " + emphrs);
            }

            Console.WriteLine(" Companys Total Max  working Days   #: " + totalworkingdays--   + "\n Total Employee hours attended in this month is " + totalemphrsinmonth);
            int totalempwage = totalemphrsinmonth * EMP_RATE_PER_HOUR;
            Console.WriteLine("  Employee Total monthly wage for Company : " + Company + " is: "+ totalempwage);
            return totalempwage;

        }
        static void Main(string[] args)
        {
            ComputeWage("Reliance", 100, 30, 240);
            ComputeWage("tata", 120, 26, 208);
            ComputeWage("Microsoft", 150, 26, 180);
        }
    }
}
