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

        public int FullDayHrs = 8;
        public void CheckAttendence()
        {
            Random random = new Random();
            int attendence = random.Next(0,3);
            switch (attendence)
            {
                case ISFULLTIME:
                    FullDayHrs = 8;
                    Console.WriteLine("Employee is Present");
                    break;
                case ISPARTTIME:
                    FullDayHrs = 4;
                    Console.WriteLine("Employee is working PartTime");
                    break;
                default:
                    FullDayHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        
            Console.WriteLine("Daily wage: " + FullDayHrs*WAGEPERHOUR);
        }
    }
}
