using System;

namespace PayrollServicesUsingADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payroll Services ADO.NET!");
            

            //Creating a object for employeerepository
            EmployeeRepository repository = new EmployeeRepository();
            repository.UpdateSalary();
            Console.ReadLine();

        }
    }
}
