using System;

class Program 
{
  public static void Main (string[] args) {

    // Definition of variables
    double baseRate = 200;
    double hourRate = 150;
    double mileRate = 2;
    
    // User Inputs
    Console.WriteLine("Estimate the number of hours for the job: ");
    double hours = double.Parse(Console.ReadLine());
    Console.WriteLine("How many miles for the job?");
    double miles = double.Parse(Console.ReadLine());

    // Calculations and final cost
    Console.WriteLine("The estimate cost for moving is: $" + (baseRate + (hours * hourRate) + (miles * mileRate)));
  
  }
}