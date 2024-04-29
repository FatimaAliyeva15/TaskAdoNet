using Business.Services.Abstracts;
using Core.Abstracts;
using Core.Models;
using Data.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class EmployeeService: IEmployeeService
    {
        IEmployeeRepository _employeeRepository = new EmployeeRepository();

        public void CreateEmployee(Employee employee)
        {
            _employeeRepository.Create(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.Delete(id);
        }

        public List<Employee> GetAllEmployee()
        {
            return _employeeRepository.GetAll();
        }

        public void UpdateEmployee(int id, double salary)
        {
            _employeeRepository.Update(id, salary);
        }
    }
}
