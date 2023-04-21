using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int PRESENT = 1;
        const int WAGEPERHOUR = 20;
        public void CheckAttendence()
        {
            int FullDayHrs = 8;
            Random random = new Random();
            int attendence = random.Next(0,2);
            if (attendence == PRESENT)
            {
                FullDayHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                FullDayHrs= 0;
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Daily wage: " + FullDayHrs*WAGEPERHOUR);
        }
    }
}
