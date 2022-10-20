using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase05EmpWage
{
    internal class UserCase05EmpWage
    {
        public const int IS_Parttime = 0;
        public const int IS_Fulltime = 1;
        public const int EMP_RATE_PER_HOUR = 100;
        public const int NUM_OF_WorkingDays = 20;
        public const int MAX_HRS_PER_MONTH = 100;


        public void EmpWage05()
        {
            int emphrs = 0;
            int empwage = 0;
            int totalempwage = 0;
            for (int day=1;day< NUM_OF_WorkingDays; day ++)
            {
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
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalempwage += empwage;

                Console.WriteLine(" Days #: " +day + "\n   Employee Wage is " +empwage);
            }

            Console.WriteLine("  Employee Total monthly wage for Company :" + totalempwage);

        }
        private static void Main(string[] args)
        {
            UserCase05EmpWage Case05EmpWage = new UserCase05EmpWage();
            Case05EmpWage.EmpWage05();
        }
    }
}
