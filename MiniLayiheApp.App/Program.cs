
using MiniLayiheApp.App.Services.Implementations;
using MiniLayiheApp.App.Services.Interfaces;

IEmployeeService employeeService = new EmployeeService();

Console.WriteLine("0. Close");
Console.WriteLine("1. Emloyee Create");
Console.WriteLine("2. Employee Update");
Console.WriteLine("3. Employee Delete");
Console.WriteLine("4. Employee ShowAll");
Console.WriteLine("5. Employee ShowById");

string Request=Console.ReadLine();

while (Request != "0") 
{
    switch (Request) 
    {
        case "1":
            Console.Clear();
            employeeService.Creat();
            break;
            case "2":
            Console.Clear();
            employeeService.Update();
            break;
        case "3":
            Console.Clear();
            employeeService.Delete();
            break;
        case "4":
            Console.Clear();
            employeeService.GetAll();
            break;
        case "5":
            Console.Clear();
            employeeService.Get();
            break;
            default:
            Console.WriteLine("Select valid option");
            break;
    }

    Console.WriteLine("0. Close");
    Console.WriteLine("1. Emloyee Create");
    Console.WriteLine("2. Employee Update");
    Console.WriteLine("3. Employee Delete");
    Console.WriteLine("4. Employee ShowAll");
    Console.WriteLine("5. Employee ShowById");

    Request = Console.ReadLine();
}