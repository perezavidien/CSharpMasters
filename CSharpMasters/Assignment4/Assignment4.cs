using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMasters
{
    public class Assignment4
    {
        public static void Run()
        {
            var emp1 = CreateEmployee("Juan", "Dela", "Cruz", 500000);
            var emp2 = CreateEmployee("Jay", "Buen", "Doque", 1500, 50);

            Console.WriteLine($"{emp1.GetFullName()}'s Monthly Payout is Php {emp1.Payout()}");
            Console.WriteLine($"{emp2.GetFullName()}'s Monthly Payout is Php {emp2.Payout()}.");

            Console.ReadLine();
        }

        public static Employee CreateEmployee(
            string firstName, string middleName, string lastName,
            decimal annualSalary)
        {
            return new Employee
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                AnnualSalary = annualSalary
            };
        }
        public static Contractual CreateEmployee(
            string firstName, string middleName, string lastName,
            decimal hourlyRate, int workHours)
        {
            return new Contractual
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                HourlyRate = hourlyRate,
                TotalHours = workHours
            };
        }

    }
}
