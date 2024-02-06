using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2HW
{
    public abstract class Payroll
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public abstract double Pay { get; }

        protected Payroll(int employeeId, string firstName, string lastName, DateTime hireDate)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
        }
    }

    public class Sales : Payroll
    {
        public double Draw { get; set; }
        public double CommissionRate { get; set; }
        public double GrossSales { get; set; }

        public override double Pay => Math.Max(CommissionRate * GrossSales, Draw);

        public Sales(int employeeId, string firstName, string lastName, DateTime hireDate, double draw, double commissionRate, double grossSales)
            : base(employeeId, firstName, lastName, hireDate)
        {
            Draw = draw;
            CommissionRate = commissionRate;
            GrossSales = grossSales;
        }
    }

    public class Salary : Payroll
    {
        public double MonthlySalaryAmount { get; set; }
        public double Bonus { get; set; }

        public override double Pay => MonthlySalaryAmount / 2 + Bonus;

        public Salary(int employeeId, string firstName, string lastName, DateTime hireDate, double monthlySalaryAmount, double bonus)
            : base(employeeId, firstName, lastName, hireDate)
        {
            MonthlySalaryAmount = monthlySalaryAmount;
            Bonus = bonus;
        }
    }

    public class Hourly : Payroll
    {
        public double Hours { get; set; }
        public double HourlyRate { get; set; }

        public override double Pay
        {
            get
            {
                double regularPay = Math.Min(Hours, 40) * HourlyRate;
                double overtimePay = Math.Max(0, Hours - 40) * HourlyRate * 1.5;
                return regularPay + overtimePay;
            }
        }

        public Hourly(int employeeId, string firstName, string lastName, DateTime hireDate, double hours, double hourlyRate)
            : base(employeeId, firstName, lastName, hireDate)
        {
            Hours = hours;
            HourlyRate = hourlyRate;
        }
    }
}