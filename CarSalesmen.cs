using System;
public class CarSalesman : Salesmen{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    public override void Sell()
    {
        throw new System.NotImplementedException();
    }
}
}