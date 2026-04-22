using System;

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

        try
        {
            Console.Write("Enter Order ID: ");
            order.OrderId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            order.CustomerName = Console.ReadLine();

            Console.Write("Enter Amount: ");
            order.Amount = double.Parse(Console.ReadLine());

            processor.PlaceOrder(order);

            processor.OnOrderPlaced -= sms.SendSMS;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Process completed");
        }
    }
}
