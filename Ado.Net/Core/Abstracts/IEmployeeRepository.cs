using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts
{
    public interface IEmployeeRepository
    {
        void Create(Employee employee);
        void Delete(int id);
        List<Employee> GetAll();
        void Update(int id, double salary);

    }
}
