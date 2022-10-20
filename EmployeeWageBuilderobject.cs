using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usercase09EmployeWage
{
    public class EmployeeWageBuilderobject
    {
        const int IS_Parttime = 0;
        const int IS_Fulltime = 1;
        int emphrs = 0;
        int totalemphrsinmonth = 0;
        int totalworkingdays = 0;
        private int MAX_HRS_PER_MONTH;
        public int NUM_OF_WorkingDays;
        private string Company;
        private int EMP_RATE_PER_HOUR;
         int totalempwage;
        public EmployeeWageBuilderobject(string Company, int EMP_RATE_PER_HOUR, int NUM_OF_WorkingDays, int MAX_HRS_PER_MONTH)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUM_OF_WorkingDays = NUM_OF_WorkingDays;
            this.MAX_HRS_PER_MONTH = MAX_HRS_PER_MONTH;
            this.totalempwage = totalempwage;

        }
        public int ComputeWage()
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
            totalempwage = totalemphrsinmonth * this.EMP_RATE_PER_HOUR;
            Console.WriteLine("  Employee Total monthly wage for Company : " + Company + " is: " + totalempwage);
            return totalempwage;
            
        }
            public string toString()
            {
                return "total employee wage for the company " + this.Company + "is" + this.totalempwage;
            }
           
    }
    
}

