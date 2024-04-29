using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}, Salary: {Salary}";
        }

        public Employee()
        {
            
        }

        public Employee(string name, string surname, double salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }
    }
}
