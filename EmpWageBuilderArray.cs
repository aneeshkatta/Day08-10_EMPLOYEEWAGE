using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Usercase10interfaceapproch
{
     public class EmpWageBuilderArray
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME=2;
        private int numofcompany = 0;
        private companyEmpWage[] companyEmpWageArray;
         
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new companyEmpWage[5];

        }
        public void addCompanyEmployeeWage(string Company, int EMP_RATE_PER_HOUR, int NUM_OF_WorkingDays, int MAX_HRS_PER_MONTH)
        {
            companyEmpWageArray[this.numofcompany] = new companyEmpWage(Company, EMP_RATE_PER_HOUR, NUM_OF_WorkingDays, MAX_HRS_PER_MONTH);
            numofcompany++;

        }
        public void computeEmpWage()
        {
            for(int i=0;i<numofcompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }

        }
        
            private int computeEmpWage(companyEmpWage companyWage)
             {
            int emphrs = 0;
            int totalemphrsinmonth = 0;
            int totalworkingdays = 0;
            while (totalemphrsinmonth < companyWage.MAX_HRS_PER_MONTH && totalworkingdays < companyWage.NUM_OF_WorkingDays)
            {
                totalworkingdays++;

                Random random = new Random();
                int empCheck = random.Next(0, 2);

                switch (empCheck)
                {
                    case IS_PARTTIME:
                        emphrs = 4;
                        break;

                    case IS_FULLTIME:
                        emphrs = 8;
                        break;

                    default:
                        emphrs = 0;
                        break;
                }

                totalemphrsinmonth += emphrs;
                Console.WriteLine(" Days #: " + totalworkingdays + "\n   Employee hrs is " + emphrs);
            }


            return totalemphrsinmonth * companyWage.EMP_RATE_PER_HOUR;
            int x= totalemphrsinmonth * companyWage.EMP_RATE_PER_HOUR;
            Console.WriteLine(x);
        }

    }
}
