using Core.Abstracts;
using Core.Models;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concretes
{
    public class EmployeeRepository : IEmployeeRepository
    {
        AppDbContext appDbContext;
        public EmployeeRepository()
        {
            this.appDbContext = new AppDbContext();
        }
        public void Create(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("cannot be null");
            }
            if (string.IsNullOrEmpty(employee.Name))
            {
                throw new ArgumentNullException("cannot be null");
            }

            if (string.IsNullOrEmpty(employee.Surname))
            {
                throw new ArgumentNullException("cannot be null");
            }
            if (employee.Salary <= 0)
            {
                throw new ArgumentException();
            }

            string createCommand = $"insert into Employees values('{employee.Name}','{employee.Surname}', {employee.Salary})";
            int result = appDbContext.NonQuery(createCommand);
        }

        bool EmployeeExists(int id)
        {
            string query = $"SELECT COUNT(*) FROM Employees WHERE Id = {id}";
            int count = Convert.ToInt32(appDbContext.Query(query).Rows[0][0]);
            return count > 0;
        }

        public void Delete(int id)
        {
            if (!EmployeeExists(id))
            {
                throw new InvalidOperationException($"Employee not found");
            }

            string deleteCommand = $"delete from Employees where Id = {id}";
            appDbContext.NonQuery(deleteCommand);
        }

        public List<Employee> GetAll()
        {
            string query = "Select * from Employees";
            DataTable dataTable = appDbContext.Query(query);
            List<Employee> employees = new List<Employee>();
            foreach (DataRow item in dataTable.Rows)
            {
                employees.Add(new Employee()
                {
                    Id = int.Parse(item["Id"].ToString()),
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Salary = double.Parse(item["Salary"].ToString())
                });
            }
            return employees;
        }

        public void Update(int id, double salary)
        {
            if (!EmployeeExists(id))
            {
                throw new InvalidOperationException($"Employee not found");
            }

            string updateCommand = $"UPDATE Employees SET Salary = {salary} Where Id={id}";
            appDbContext.NonQuery(updateCommand);
        }
    }
}
