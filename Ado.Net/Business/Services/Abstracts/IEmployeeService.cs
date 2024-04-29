using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts
{
    public interface IEmployeeService
    {
        void CreateEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployee();
        void UpdateEmployee(int id, double salary);
    }
}
