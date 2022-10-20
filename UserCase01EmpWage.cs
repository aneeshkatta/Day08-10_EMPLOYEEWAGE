using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase01EmployeeWage
{
    internal class UserCase01EmpWage
    {
        
        
        public void EmpCheck()
        {
            int IS_Fulltime = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);


            if (empCheck == IS_Fulltime)
            {
                Console.WriteLine(" Employee is present");
             }
            else
            {
                Console.WriteLine(" Employee is absent");

            }
          
        }
        public static void Main(string[] args)
{
            UserCase01EmpWage EmpWagMethod = new UserCase01EmpWage();
            EmpWagMethod.EmpCheck();

        }
    }
}
