using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;
using Data.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net.Controllers
{
    public class EmployeeController
    {
        IEmployeeService _employeeService = new EmployeeService();

        public void CreateEmp()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

           
            string salaryStr = "";
            double salary;

            do
            {
                Console.Write("Salary: ");
                salaryStr = Console.ReadLine();
            }while(!double.TryParse(salaryStr, out salary));

            _employeeService.CreateEmployee(new Employee(name,surname,salary));
        }

        public void DeleteEmp()
        {
            string idStr;
            int id;
            do
            {
                Console.Write("Id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            try
            {
                _employeeService.DeleteEmployee(id);
                Console.WriteLine("Employee Deleted");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateEmp()
        {
            string idStr;
            int id;
            do
            {
                Console.Write("Id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            string salaryStr = "";
            double salary;

            do
            {
                Console.Write("Update Salary: ");
                salaryStr = Console.ReadLine();
            } while (!double.TryParse(salaryStr, out salary));

            try
            {
                _employeeService.UpdateEmployee(id, salary);
                Console.WriteLine("Employee Updated");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetAllEmps()
        {
            foreach (var item in _employeeService.GetAllEmployee())
            {
                Console.WriteLine(item);
            }
        }
    }
}
