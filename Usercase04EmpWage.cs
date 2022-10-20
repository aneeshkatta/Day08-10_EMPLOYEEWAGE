using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase04EmpWage
{
     class Usercase04EmpWage
    {
        public const int IS_Parttime = 0;
        public const int IS_Fulltime = 1;
        public const int EMP_RATE_PER_HOUR = 100;



        public void EmpWage04()
        {
            int emphrs = 0;
            int empwage = 0;
            int totalempwage = 0;
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

                Console.WriteLine(" Employee Wage is " + empwage);


        }

        private static void Main(string[] args)
        {
            Usercase04EmpWage Case04EmpWage = new Usercase04EmpWage();
            Case04EmpWage.EmpWage04();
        }

    }
}
