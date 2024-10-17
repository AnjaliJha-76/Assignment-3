using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3rd
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        // Constructor to initialize the employee details
        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        // Method to return the employee's details as a string
        public string GetEmployeeDetails()
        {
            return $"Employee Details:\n" +
                   $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"Salary: {Salary:C}"; // Format the salary as currency
        }
  
       public static void salary()
        {
            // Create an instance of the Employee class
            Employee emp = new Employee("John Doe", 30, 55000);

            // Hold the output in a string
            string employeeDetails = emp.GetEmployeeDetails();

            // Display the output (optional)
            Console.WriteLine(employeeDetails);
        }
    }
}
        

