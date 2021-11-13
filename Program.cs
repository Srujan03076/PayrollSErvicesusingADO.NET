using System;

namespace PayrollServicesUsingADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payroll Services ADO.NET!");
            EmployeeRepository repository = new EmployeeRepository();
            Console.WriteLine("Id Name BasicPay Startdate Gender Department PhoneNumber Address Deduction Tax IncomeTax NetPay \n");
            repository.GetAllEmployee();
            Console.ReadLine();

        }
    }
}
