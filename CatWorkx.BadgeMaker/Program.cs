using System;
using System.Collections.Generic;


namespace CatWorkx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while(true)
            {
                Console.Write("Please enter first name. (Leave empty to exit): ");
                string firstName = Console.ReadLine();
                if(firstName == "") 
                {
                    break;
                }
                Console.Write("Please enter a last name:");
                string lastName = Console.ReadLine();
                Console.Write("Please enter the employee ID number: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the photo URL: ");
                string photoUrl = Console.ReadLine();
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
    }
}
