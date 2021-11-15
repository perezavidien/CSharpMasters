using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpMasters
{
    public class Assignment5
    {
        public static void Run()
        {
            var employeeList = new List<Employee2>
            {
                CreateEmployee("Juan", "Dela", "Cruz", SalaryFrequency.Monthly, 40000),
                CreateEmployee("Bea", "A.", "Rosales", SalaryFrequency.Hourly, 2000, 40),
                CreateEmployee("Babes", "Dela", "Macatangay", SalaryFrequency.CommissionBased, 6000, 2),
                CreateEmployee("Jun", "O.", "Malabanan", SalaryFrequency.Daily, 500, 20),
                CreateEmployee("Tess", "V.", "Sy", SalaryFrequency.CommissionBased, 10000, 5),
                CreateEmployee("Jay", "B.", "Chan", SalaryFrequency.Monthly, 30000),
                CreateEmployee("Arkin", "P", "Doque", SalaryFrequency.Hourly, 1500, 80),
                CreateEmployee("Shey", "Z.", "Alapaap", SalaryFrequency.CommissionBased, 6000, 10),
                CreateEmployee("Dalisay", "M.", "Macatagay", SalaryFrequency.Hourly, 1500, 40),
                CreateEmployee("Kasandra", "L.", "Cortez", SalaryFrequency.Monthly, 55000)
            };

            var sortedEmployees = employeeList.OrderBy(e => e.GetMonthlyPayout()).ToList();

            foreach (var e in sortedEmployees)
            {
                Console.WriteLine($"{e.GetFullName()}'s Monthly Payout is Php {e.GetMonthlyPayout()}");
            }

            Console.ReadLine();
        }

        public static Employee2 CreateEmployee(
            string firstName, string middleName, string lastName,
            SalaryFrequency salaryFrequency, decimal rate, int totalWork = 0)
        {
            switch (salaryFrequency)
            {
                case SalaryFrequency.Hourly:
                    return new HourlyEarner
                    {
                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        HourlyRate = rate,
                        TotalHoursWorked = totalWork
                    };
                case SalaryFrequency.Daily:
                    return new DailyEarner
                    {
                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        TotalDaysWorked = totalWork,
                        DailyRate = rate
                    };
                case SalaryFrequency.CommissionBased:
                    return new CommissionBasedEarner
                    {
                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        TotalSales = totalWork,
                        CommissionRate = rate
                    };
                default:
                    return new Employee2
                    {
                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        Salary = rate
                    };
            }
        }
    }
}
