using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase06EmpWage
{
    internal class UserCase06EmpWage
    {
        public const int IS_Parttime = 0;
        public const int IS_Fulltime = 1;
        public const int EMP_RATE_PER_HOUR = 100;
        public const int NUM_OF_WorkingDays = 20;
        public const int MAX_HRS_PER_MONTH = 100;


        public void EmpWage06()
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

                Console.WriteLine(" Companys Total Max  working Days   #: " + totalworkingdays-- + "\n Total Employee hours attended in this month is " + totalemphrsinmonth);
                int totalempwage = totalemphrsinmonth * EMP_RATE_PER_HOUR;
                Console.WriteLine("  Employee Total monthly wage for Company :" + totalempwage);
               
         }
        private static void Main(string[] args)
        {
            UserCase06EmpWage Case06EmpWage = new UserCase06EmpWage();
            Case06EmpWage.EmpWage06();
        }

    }
}
