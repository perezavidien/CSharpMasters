using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMasters
{
    public class Employee2
    {
        internal decimal Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public Employee2() { }
        ~Employee2() { }
        public void Work() { }
        public virtual decimal GetMonthlyPayout()
        {
            return Salary;
        }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

        public string IntroduceEmployeeWithCompensation()
        {
            return $"{FirstName} {MiddleName} {LastName} earns {GetMonthlyPayout()} per month";
        }
    }


    //public interface IConsultant
    //{
    //    public string ProjectName { get; set; }
    //}


    //public interface IQualityEngineer 
    //{
    //    public string TestingTool { get; set; }
    //}


    //public interface IDeveloper
    //{
    //    public string ProgrammingLanguage { get; set; }
    //}

    public class MonthlyEarner : Employee2
    { }

    public class DailyEarner : Employee2
    {
        public override decimal GetMonthlyPayout()
        {
            return TotalDaysWorked * DailyRate;
        }

        public int TotalDaysWorked { get; set; } // todo  should reset after giving salary
        internal decimal DailyRate { get; set; }
    }
    public class HourlyEarner : Employee2
    {
        public override decimal GetMonthlyPayout()
        {
            return TotalHoursWorked * HourlyRate;
        }

        public int TotalHoursWorked { get; set; } // todo  should reset after giving salary
        internal decimal HourlyRate { get; set; }
    }

    public class CommissionBasedEarner : Employee2
    {
        public override decimal GetMonthlyPayout()
        {
            return CommissionRate * TotalSales;
        }
        internal decimal CommissionRate { get; set; }
        public int TotalSales { get; set; } // todo  should reset after giving salary
    }
}
