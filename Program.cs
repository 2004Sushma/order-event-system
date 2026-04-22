using System;
public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double Amount { get; set; }
}

public class OrderProcessor
{
    public delegate void OrderPlacedHandler(Order order);

    public event OrderPlacedHandler OnOrderPlaced;

    public void PlaceOrder(Order order)
    {
        Console.WriteLine("\nOrder Placed: " + order.OrderId);
        OnOrderPlaced?.Invoke(order);
    }
}

public class EmailService
{
    public void SendEmail(Order order)
    {
        Console.WriteLine("Email sent to customer");
    }
}

public class SMSService
{
    public void SendSMS(Order order)
    {
        Console.WriteLine("SMS sent to customer");
    }
}

public class LoggerService
{
    public void LogOrder(Order order)
    {
        Console.WriteLine("Order logged successfully");
    }
}

class Program
{
    static void Main()
    {
        OrderProcessor processor = new OrderProcessor();

        EmailService email = new EmailService();
        SMSService sms = new SMSService();
        LoggerService logger = new LoggerService();

        processor.OnOrderPlaced += email.SendEmail;
        processor.OnOrderPlaced += sms.SendSMS;
        processor.OnOrderPlaced += logger.LogOrder;

        Order order = new Order();

        Console.Write("Enter Order ID: ");
        order.OrderId = int.Parse(Console.ReadLine());

        Console.Write("Enter Customer Name: ");
        order.CustomerName = Console.ReadLine();

        Console.Write("Enter Amount: ");
        order.Amount = double.Parse(Console.ReadLine());

        processor.PlaceOrder(order);
    }
}