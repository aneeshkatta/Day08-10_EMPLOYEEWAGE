using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usercase03EmployeeWage
{
    class Usercase03EmpWage
    {
        public void EmpWage03()
        {
                int IS_Parttime = 0;
                int IS_Fulltime = 1;
                int EMP_RATE_PER_HOUR = 100;
                int emphrs = 0;
                int empwage = 0;
                int totalempwage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 2);


            if (empCheck == IS_Parttime)
            {
                emphrs = 4;
            }
            else if (empCheck == IS_Fulltime)
            {
                emphrs = 8;
            }
            else 
            { 
                    emphrs = 0;
                    
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            totalempwage += empwage;

            Console.WriteLine(" Employee Wage is " + empwage);

             }
        public static void  Main(string[] args)
        {
            Usercase03EmpWage Case03EmpWage = new Usercase03EmpWage();
            Case03EmpWage.EmpWage03();
        }

    }
}
