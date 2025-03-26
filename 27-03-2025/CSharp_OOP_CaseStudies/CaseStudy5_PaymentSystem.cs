
using System;

interface IPayment
{
    void MakePayment(double amount);
}

class CreditCard : IPayment
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Paid ${amount} using Credit Card.");
    }
}

class PayPal : IPayment
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Paid ${amount} using PayPal.");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment;

        payment = new CreditCard();
        payment.MakePayment(150.00);

        payment = new PayPal();
        payment.MakePayment(200.00);
    }
}
