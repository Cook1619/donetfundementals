using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           CarSalesman steve = new CarSalesman("Steve", "Smith");
           Console.WriteLine(steve.FullName);
           steve.Sell();

           RetailSalesPerson erik =  new RetailSalesPerson("Erik", "Jimbo");
           Console.WriteLine(erik.FullName);
           erik.Sell();
        }
    }
}
