using System;

namespace ems_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Creating an Employee");
            Console.WriteLine("--------------------");

            Employee john = new Employee("John", "Smith", "johnsmith@gmail.com", new DateTime(1995, 12, 25), 25.0, EmployeeType.Research);

            string johnToJson = john.ConvertToJson();
            Console.WriteLine(johnToJson);

            john.DisplayEmployeeDetails();

            john.PerformWork();
            john.PerformWork();
            john.PerformWork();
            john.PerformWork();
            john.PerformWork();

            double johnReceivedWage = john.ReceiveWage(true);
            Console.WriteLine($"Wage paid (by the program): {johnReceivedWage}");

            Console.WriteLine("Creating an Employee");
            Console.WriteLine("--------------------");

            Employee emily = new Employee("Emily", "Cruz", "emilycruz@gmail.com", new DateTime(1996, 4, 8), 30.0, EmployeeType.Manager);

            emily.DisplayEmployeeDetails();

            emily.PerformWork();
            emily.PerformWork();
            emily.PerformWork();
            emily.PerformWork();
            emily.PerformWork();

            double emilyReceivedWage = emily.ReceiveWage(true);
            Console.WriteLine($"Wage paid (by the program): {emilyReceivedWage}");

        }
    }
}
