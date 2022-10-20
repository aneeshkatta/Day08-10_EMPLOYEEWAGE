using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usercase10interfaceapproch
{
    public  class companyEmpWage
    {
        public int MAX_HRS_PER_MONTH;
        public int NUM_OF_WorkingDays;
        public string Company;
       public int EMP_RATE_PER_HOUR;
       public  int totalempwage;
        public companyEmpWage(string Company, int EMP_RATE_PER_HOUR, int NUM_OF_WorkingDays, int MAX_HRS_PER_MONTH)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUM_OF_WorkingDays = NUM_OF_WorkingDays;
            this.MAX_HRS_PER_MONTH = MAX_HRS_PER_MONTH;
        }
        public void setTotalEmpWage(int totalempwage) 
        {
            this.totalempwage = totalempwage;
        }
        public string toString()
        {
            return "total employee wage for the company " + this.Company + "is" + this.totalempwage;
        }
    }
       
}
