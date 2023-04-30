using System;
using System.Collections.Generic;
using System.Globalization;
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
        const int TOTALWORKINGDAYS = 20, MAXIMUMHRS=100;

        public void CheckAttendence()
        {
              int TotalHrs = 0,day=1;

        Random random = new Random();
            while (day <= TOTALWORKINGDAYS && day <= 100)
            {
                int attendence = random.Next(0, 3);
                string message = "Day " + day + ": ";
                switch (attendence)
                {
                    case ISFULLTIME:
                        TotalHrs += 8;
                        message += "Employee is Present";
                        break;
                    case ISPARTTIME:
                        TotalHrs += 4;
                        message += "Employee is working PartTime";
                        break;
                    default:
                        TotalHrs += 0;
                        message += "Employee is Absent";
                        break;
                }
                Console.WriteLine(message);
                day++;
            }
            Console.WriteLine("Total wage: " + TotalHrs*WAGEPERHOUR);
        }
    }
}
