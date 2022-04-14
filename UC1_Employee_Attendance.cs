using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC1_Employee_Attendance
    {
        public static int EmployeeAttendance()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == 1)
            {
                Console.WriteLine("employee is present");
            }
            else if (empcheck == 2)
            {
                Console.WriteLine("employee is part time");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            return empcheck;
        }
        
        
    }
}
