using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a couple of instances of the Employee class
            Employee employee1 = new Employee("Dave", "Barnes");
            Employee employee2 = new Employee("Joe", "Somebody");

            //Showing how to use an array with objects
            Employee[] employees = new Employee[10];

            
            //Instanciate some employees into the array
            employees[0] = new HourlyEmployee("James", "Kirk", 14.05m);
            employees[1] = new SalaryEmployee("Jean-Luc", "Picard", 55273.00m);
            employees[2] = new HourlyEmployee("Benjamin", "Sisko", 14.59m);
            employees[3] = new SalaryEmployee("Kathryn", "Janeway", 67123);
            employees[4] = new SalaryEmployee("Johnathan", "Archer", 12232);

            employees[5] = new HourlyEmployee("James", "Kirk", 12.05m);
            employees[6] = new SalaryEmployee("Jean-Luc", "Picard", 55123.00m);
            employees[7] = new HourlyEmployee("Benjamin", "Sisko", 14.56m);
            employees[8] = new SalaryEmployee("Kathryn", "Janeway", 67000);
            employees[9] = new SalaryEmployee("Johnathan", "Archer", 12000);

            //We are creating a new UserInterface class, and it's okay
            //that the UserInterface class does not have a defined
            //constructor. It will have a default one provide to us that
            //we can take advantage of by just not passing in any parameters
            UserInterface ui = new UserInterface();

            //This is not a valid statement. Because we are trying to make
            //an instance of a static class, it won't work.
            //StaticUserInterface stui = new StaticUserInterface();

            //Call the GetUserInput method of the UI class. It will return
            //a valid integer that represents the choice they want to do.
            int choice = ui.GetUserInput();

            //To use a static class to execute methods we simply call the
            //method on the class name, (or type). Since it is not possible
            //to use the 'new' keyword and make an instance, the only way
            //we can access the class is through the class name, so that
            //is what we do. Here we are calling the GetUserInterface method
            //on the class name to get it to run.
            //choice = StaticUserInterface.GetUserInput();

            //While the choice is not the exit choice (which in this case is 2)
            while (choice != 2)
            {
                //If the choice is 1, which in this case it has to be, but if there
                //were more menu options it might not be so obvious.
                if (choice == 1)
                {
                    //Create a empty string to concat to.
                    string allOutput = "";
                    //For each Employee in the employees array.
                    foreach (Employee employee in employees)
                    {
                        //So long as the spot in the array is not null
                        if (employee != null)
                        {
                            //Concat the employee changed to a string plus a new line
                            //to the allOutput string.
                            allOutput += employee.ToString() + Environment.NewLine;
                        }
                    }
                    //Now that the large string containing what I would like to output
                    //is created, I can output it to the screen using the
                    //PrintAllOutput method of the UI class.
                    ui.PrintAllOutput(allOutput);
                }

                //Now that the "Work" that we wanted to do is done,
                //We need to re-prompt the user for some input
                choice = ui.GetUserInput();
            }


        }
    }
}
