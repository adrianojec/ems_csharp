using System;
namespace ems_csharp
{
    internal struct WorkTask
    {
        public string description;
        public int hours;

        public void PerformWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} has been performed.");
        }
    }
}

