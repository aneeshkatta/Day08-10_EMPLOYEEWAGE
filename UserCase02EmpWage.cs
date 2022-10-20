using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase02EmployeeWage
{
    class UserCase02EmpWage
    {



        public void EmpWage()
        {

            int IS_Fulltime = 1;
            int EMP_RATE_PER_HOUR = 100;
            int emphrs = 0;
            int empwage = 0;
            int totalempwage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);


            if (empCheck == IS_Fulltime)
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
        public static void Main(string[] args)
        {
            UserCase02EmpWage Case02EmpWage = new UserCase02EmpWage();
            Case02EmpWage.EmpWage();
        }
    }
}
