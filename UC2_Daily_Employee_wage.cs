using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC2_Daily_Employee_wage
    {
       public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public static void EmployeeSalaryofDay()
        {
            
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
        
            int empcheck = UC1_Employee_Attendance.EmployeeAttendance();
            switch(empcheck)
            {
                case IS_FULL_TIME:
                    emphrs = 8;
                    break;
                    case IS_PART_TIME:
                    emphrs = 4;
                    break;
                default:
                    emphrs =0;
                    break;
            }
            
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage of the day is :" + empwage);
            Console.WriteLine("monthly salary of employee is :" + empwage*30);
        }
    }
}
