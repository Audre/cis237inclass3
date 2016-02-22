using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    public class HourlyEmployee : Employee
    {
        // Constants for the hours per week and the weeks per year
        private const decimal HOURS_PER_WEEK = 40;
        private const decimal WEEKS_PER_YEAR = 52;

        // Create a backing field for the hourly rate
        private decimal hourlyRate;

        // 3 Parameter Constructor that uses the parent's constructor
        // to do some of the work. 
        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate) : base(firstName, lastName)
        {
            this.hourlyRate = hourlyRate;
        }

        // Public property for the Salary backing field
        public decimal Salary
        {
            get
            {
                // Need to calculate the Salary using the constants
                return this.hourlyRate * WEEKS_PER_YEAR * HOURS_PER_WEEK;
            }
        }

        // Public override of the ToString() method. It uses the parent's
        // toString method to get some of its works done. 
        public override string ToString()
        {
            return base.ToString() + " " + this.Salary.ToString("c");
        }

        // This is the override for the abstract method we have declared in the
        // Employee class. We are required to provide an implementation since it 
        // was declared abstract in Employee.
        public override string GetFormattedSalary()
        {
            return this.Salary.ToString("C");
        }
    }
}
