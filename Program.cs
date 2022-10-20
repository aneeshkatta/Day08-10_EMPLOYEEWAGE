using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usercase10interfaceapproch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWagebuilder = new EmpWageBuilderArray();
            empWagebuilder.addCompanyEmployeeWage("Dmart", 20, 10, 10);
            empWagebuilder.addCompanyEmployeeWage("Reliance", 20, 2, 10);
            empWagebuilder.computeEmpWage();

        }

    }
}
