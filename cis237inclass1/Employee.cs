using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // This is an abstract class. It is made abstract by adding the 'abstract' keyword
    // before the word class. 
    public abstract class Employee : IEmployee
    {
        //Backing fields
        protected string firstName;
        protected string lastName;

        //properties for the backing fields
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //Override method that will print all of the fields
        //It overrides the default ToString that every object gets for free!
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        // An abstract method MUST have no method body. Hence, the ; at the end .
        // An abstract method MUST be overridden in all child classes. 
        // We made this method abstract because based on the information that this 
        // class has, we have no idea how to calculate a salary, let along format one.
        // Declaring it abstract leaves the implementation details to the child class
        // to figure out. 
        public abstract string GetFormattedSalary();

        // A virtual method MUST have a method body, even if it is empty. 
        // A virtual method CAN be overridden in child classes, but is not required to be.
        // We made this method virtual because we already have all of the needed
        // information to provide a method body. We simply left it virtual in case
        // a subclass would like to override it for some reason. 
        public virtual string GetLastNameFirstName()
        {
            return this.lastName + ", " + this.firstName;
        }

        //2 Parameter constructor
        public Employee(string firstName, string lastName)
        {
            //Assign the passed in values to the fields
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Default constructor
        public Employee()
        {
            //Let's just leave this blank
        }
    }
}
