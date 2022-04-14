// See https://aka.ms/new-console-template for more information
using System;
namespace Employee_wage_Computation
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Computation");
            UC2_Daily_Employee_wage.EmployeeSalaryofDay();
            UC5_wages_for_a_month.CalculatingWagesforaMonth();
            UC6_hours_or_days_reached_for_a_month.TotalWorkingHours();
            UC3_part_time_employee.parttime_employee();
            Uc4_Switch_case.switch_statement();
            Console.ReadKey();
        }
    }
}

