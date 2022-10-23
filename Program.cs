using System;

namespace ems_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //string userAction;
            //do
            //{
            //    Console.WriteLine("Please choose your action: ");
            //    Console.WriteLine("1. Add Employee: ");
            //    Console.WriteLine("2. Update Employee: ");
            //    Console.WriteLine("3. Delete Employee: ");
            //    Console.WriteLine("4. View Employees: ");
            //    Console.WriteLine("0. Quit Console ");
            //    userAction = Console.ReadLine();

            //    switch (userAction)
            //    {
            //        case "1":
            //            Console.WriteLine("Adding employee ...");
            //            break;
            //        case "2":
            //            Console.WriteLine("Updating employee ...");
            //            break;
            //        case "3":
            //            Console.WriteLine("Deleting employee ...");
            //            break;
            //        case "4":
            //            Console.WriteLine("Loading employees ...");
            //            break;
            //        case "0":
            //            Console.WriteLine("Closing Application ...");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input!");
            //            break;
            //    }

            //} while (userAction != "0");

            //Console.WriteLine("Thank you for using the app.");

            //Console.WriteLine("Creating an Employee");
            //Console.WriteLine("--------------------");

            Employee john = new Employee("John", "Smith", "johnsmith@gmail.com", new DateTime(1995, 12, 25), 25.0);

            john.PerformWork(50);

            int minimumBonus = 100;
            //int receivedBonus = john.CalculateBonus(minimumBonus);
            //Console.WriteLine($"The minimum bonus is {minimumBonus} and {john.firstName} has received" +
            //    $"bonus of {receivedBonus}");

            int bonusTax = 0;
            int receivedBonus = john.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
            Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and " +
                $"{john.firstName} has received a bonus of {receivedBonus}");

            //john.DisplayEmployeeDetails();

            //john.PerformWork();
            //john.PerformWork();
            //john.PerformWork();
            //john.PerformWork();
            //john.PerformWork();

            //double johnReceivedWage = john.ReceiveWage(true);
            //Console.WriteLine($"Wage paid (by the program): {johnReceivedWage}");

            //Console.WriteLine("Creating an Employee");
            //Console.WriteLine("--------------------");

            //Employee emily = new Employee("Emily", "Cruz", "emilycruz@gmail.com", new DateTime(1996, 4, 8), 30.0);

            //john.DisplayEmployeeDetails();

            //emily.PerformWork();
            //emily.PerformWork();
            //emily.PerformWork();
            //emily.PerformWork();
            //emily.PerformWork();

            //double emilyReceivedWage = emily.ReceiveWage(true);
            //Console.WriteLine($"Wage paid (by the program): {emilyReceivedWage}");

        }
    }
}
