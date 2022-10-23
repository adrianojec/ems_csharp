using System;
using Newtonsoft.Json;

namespace ems_csharp
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int hoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        public EmployeeType type;

        const int minimalHoursWorked = 1;

        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName, lastName, email, birthDay, 0, EmployeeType.StoreManager)
        {}

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate, EmployeeType type)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;
            this.hourlyRate = hourlyRate;
            this.type = type;
        }

        public void PerformWork() => PerformWork(minimalHoursWorked);

        public void PerformWork(int hours)
        {
            hoursWorked += hours;
            Console.WriteLine($"{firstName} {lastName} has worked for {hoursWorked} hour(s)");

        }

        public int CalculateBonus(int bonus)
        {
            if (hoursWorked > 10) bonus *= 2;
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{
        //    if (hoursWorked > 10) bonus *= 2;
        //    if (bonus >= 200)
        //    {
        //        bonusTax = bonus / 10;
        //        bonus -= bonusTax;
        //    }

        //    Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");

        //    return bonus;
        //}

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (hoursWorked > 10) bonus *= 2;
            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");

            return bonus;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            if(type == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager.");
                wage = hoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wage = hoursWorked * hourlyRate;
            }

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {hoursWorked} hour(s) of work");
            if (resetHours) hoursWorked = 0;
            return wage;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: \t{firstName}\nLast Name: \t{lastName}" +
                $"\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
    }
}

