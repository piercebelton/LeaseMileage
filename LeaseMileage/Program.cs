using System;

namespace LeaseMileage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lease Mileage Calculator!");
            Console.WriteLine("First off, what day did your lease begin?(mm/dd/yyyy)");
            DateTime initialLeaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Great! Next up, how many miles per year are you allotted?");
            double milesPerYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Finally, what is your lease term in years? (generally 2 or 3)");
            double leaseTerm = Int32.Parse(Console.ReadLine());
            double totalDaysInLease = leaseTerm * 365;
            double percentageOfLeaseCompleted = (DateTime.Today - initialLeaseDate).TotalDays / totalDaysInLease;
            double totalMilesAllotted = milesPerYear * leaseTerm;
            double projectedMileage = totalMilesAllotted * percentageOfLeaseCompleted;
            Console.WriteLine("Based on the figures you have entered and today's date, you should have {0} miles on your odometer.", Math.Floor(projectedMileage));
        }
    }
}
