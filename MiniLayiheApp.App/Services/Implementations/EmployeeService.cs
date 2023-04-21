
using MiniLayiheApp.App.Services.Interfaces;
using MiniLayiheApp.Core.Models;
using MiniLayiheApp.Data.Repositories;

namespace MiniLayiheApp.App.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
       private readonly EmployeeRepository _employeeRepository= new EmployeeRepository();
        public void Creat()
        {
            Employee employee = new Employee();
            Console.WriteLine("Add Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Add Surname");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("Add Salary");
            employee.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Add Position");
            employee.Position = Console.ReadLine();
            _employeeRepository.Create(employee);
        }

        public void Delete()
        {
            Console.WriteLine("Enter Id");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee is not found");
            }
            else 
            {
                _employeeRepository.Delete(employee);
            }
        }

        public void Get()
        {
            Console.WriteLine("Enter Id");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee is not found");
            }
            else
            {
                Console.WriteLine(employee);
            }
        }

        public void GetAll()
        {
            List<Employee> employees= _employeeRepository.GetAll();

            foreach (var item in employees) 
            {
                Console.WriteLine(item);
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter Id");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee is not found");
            }
            else
            {
                Console.WriteLine("Add Name");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Add Surname");
                employee.Surname = Console.ReadLine();
                Console.WriteLine("Add Salary");
                employee.Salary= double.Parse(Console.ReadLine());
                Console.WriteLine("Add Position");
                employee.Position = Console.ReadLine();
            }
        }
    }
}
