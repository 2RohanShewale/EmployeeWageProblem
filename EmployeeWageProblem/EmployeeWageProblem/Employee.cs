using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int FULLTIME = 1;
        public void CheckAttendence()
        {
            Random random = new Random();
            int attendence = random.Next(0,2);
            if (attendence == 1)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
