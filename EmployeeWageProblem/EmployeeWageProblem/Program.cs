using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/-----Employee Wage Problem-----/");
            Employee employee = new Employee();
            employee.CheckAttendence();

            Console.ReadKey();
        }
    }
}
