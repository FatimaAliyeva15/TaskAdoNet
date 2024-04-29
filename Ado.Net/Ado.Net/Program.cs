using Ado.Net.Controllers;
using Core.Models;
using Data.Concretes;
using System.Data.SqlClient;

namespace Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employeeController = new EmployeeController();

            bool check = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create Employee");
                Console.WriteLine("2. All Employees");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("0. Exit");
                Console.WriteLine("");

                string choiceStr;
                byte choice;

                do
                {
                    Console.WriteLine("");
                    Console.Write("Sechim edin: ");
                    choiceStr = Console.ReadLine();
                } while (!byte.TryParse(choiceStr, out choice));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Create Employee");
                        Console.WriteLine("");

                        employeeController.CreateEmp();
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("All Employees");
                        Console.WriteLine("");

                        employeeController.GetAllEmps();
                        break;

                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Delete Employee");
                        Console.WriteLine("");

                        employeeController.DeleteEmp();
                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Update Employee");
                        Console.WriteLine("");

                        employeeController.UpdateEmp();
                        break;

                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Exit");
                        check = false;

                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Select Again");

                        break;

                }

            } while (check);
        }
    }
}
