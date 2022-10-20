using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Usercase09EmployeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWageBuilderobject Dmart = new EmployeeWageBuilderobject("dmart", 150, 20, 100);
            EmployeeWageBuilderobject Reliance = new EmployeeWageBuilderobject("Reliance", 200, 20, 100);
            Dmart.ComputeWage();
            Console.WriteLine(Dmart.toString());

            Reliance.ComputeWage();
            Console.WriteLine(Reliance.toString());
        }
    }


}