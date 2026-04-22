using System;

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
