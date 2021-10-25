using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMasters
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        internal decimal AnnualSalary { get; set; }
        public Employee() { }
        ~Employee() { }
        public void Work() { }
        public virtual decimal Payout()
        {
            return AnnualSalary / 12;
        }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }


    public class Consultant : Employee
    {
        public string ProjectName { get; set; }
    }


    public class QualityEngineer : Employee
    {
        public string TestingTool { get; set; }
    }


    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
    }


    public class Contractual : Employee
    {
        public override decimal Payout()
        {
            return TotalHours * HourlyRate;
        }
        internal decimal HourlyRate { get; set; }
        public int TotalHours { get; set; }
    }

    public class CommissionBasedContractual : Employee
    {
        public override decimal Payout()
        {
            return TotalHours * HourlyRate;
        }
        internal decimal HourlyRate { get; set; }
        public int TotalHours { get; set; }
    }
}
