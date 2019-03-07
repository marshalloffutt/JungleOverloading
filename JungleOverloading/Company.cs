using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Company
    {
        public string Name { get; }

        public List<Employee> jungleBoogie = new List<Employee>();

        public void addNewEmployee(Employee newEmployee)
        {
            jungleBoogie.Add(newEmployee);
        }

        public void removeEmployee(Employee employee)
        {
            jungleBoogie.Remove(employee);
        }

        public Company(string name)
        {
            Name = name;
        }

        public void listFolks()
        {
            foreach (var employee in jungleBoogie)
            {
                Console.WriteLine($"{employee.FirstName}, ");
            }
        }

    }
}
