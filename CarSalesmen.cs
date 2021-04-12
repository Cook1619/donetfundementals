using System;
public class CarSalesman : Salesmen{
 
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    public override void Sell()
    {
        Console.Write(String.Format("Hi my name is {0}. I would recommend you buy this car.", this.FullName));
    }
}
