using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSınıfveÜyeler
{
    internal class Employee
    {
        private static int employeeNumber;

        public static int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }

        private string Name;
        private string LastName;
        private string Department;

        static Employee()
        {
            employeeNumber = 0;
        }

        public Employee(string name, string lastName, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Department = department;
            employeeNumber++;
        }
    }
}
