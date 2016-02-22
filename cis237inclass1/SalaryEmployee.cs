using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // use the : to denote that this class should inherit from the class listed after the :
    public class SalaryEmployee : Employee
    {
        // Add backing field for the salary
        private decimal salary;

        // Add a propety for the salary
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        /// <summary>
        /// 3 Parameter constructor that takes the following arguments
        /// </summary>
        /// <param name="firstname">First Name of Employee</param>
        /// <param name="lastName">Last Name of Employee</param>
        /// <param name="salary">Yearly Salary the Employee Earns</param>
        public SalaryEmployee(string firstname, string lastName, decimal salary) : base(firstname, lastName)
        {
            // assign the passed in salary to the class level one. The first and last names that 
            // were passed in are assigned by callin the parent's constuctor.
            // The parent's constructor was called by the : base(firstName, lastName) that follows
            // the constructor declaration.
            this.salary = salary;
        }

        /// <summary>
        /// Print out the information of the class in a readable format
        /// </summary>
        /// <returns>String consisting of first name, last name, and salary</returns>
        public override string ToString()
        {
            // base.ToString() calls the ToString method of the parent class.
            // we can get a full string of all properties by concatenating the parent's toString
            // with the salary of this class. We leave the work of creating the parent's information
            // to the parent class. 
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
