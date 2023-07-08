using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Employee
    {
        int id;
        string firstName;
        string lastName;
        decimal salary;
        public Employee(int id, string firstName, string lastName, decimal salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public int GetId() { return id; }
        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public string GetName() { return $"{firstName} {lastName}"; }
        public decimal GetSalary() {  return salary; }
        public void SetSalary(decimal salary)
        {
            this.salary = salary;
        }
        public decimal GetAnnualSalary() { return salary * 12; }
        public decimal RaiseSalary(int percent)
        {
            salary += salary * percent / 100;
            return salary;
        }
        public override string ToString()
        {
            return $"Employee[id={id}, name={firstName} {lastName}, salary={salary}]";
        }
    }
}
