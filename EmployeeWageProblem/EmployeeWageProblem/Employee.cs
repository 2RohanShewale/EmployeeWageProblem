using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int ISFULLTIME = 1;
        const int WAGEPERHOUR = 20;
        const int ISPARTTIME = 2;
        public void CheckAttendence()
        {
            int FullDayHrs = 8;
            Random random = new Random();
            int attendence = random.Next(0,3);
            if (attendence == ISFULLTIME)
            {
                FullDayHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else if (attendence == ISPARTTIME)
            {
                FullDayHrs= 4;
                Console.WriteLine("Employee is working PartTime");
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
