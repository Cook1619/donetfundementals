using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
        //    CarSalesman steve = new CarSalesman("Steve", "Smith");
        //    Console.WriteLine(steve.FullName);
        //    steve.Sell();

        //    RetailSalesPerson erik =  new RetailSalesPerson("Erik", "Jimbo");
        //    Console.WriteLine(erik.FullName);
        //    erik.Sell();
        var grades = new List<double>() {12.3, 45.3, 23.6, 67.3};
        grades.Add(67.8);

        var result = 0.0;
        foreach (var num in grades)
        {
            result += num;
        }
        var average = result / grades.Count;
        
        Console.WriteLine("The average grade is {0}", Math.Round(average, 2));
        }
    }
}
