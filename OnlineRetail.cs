using System;
public class Order
{
    public string OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public Order(string orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }
    public virtual string GetOrderStatus()
    {
        return "Order placed, awaiting shipment.";
    }
}

public class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }
    public ShippedOrder(string orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }
    public override string GetOrderStatus()
    {
        return $"Order shipped. Tracking number: {TrackingNumber}";
    }
}
public class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }
    public DeliveredOrder(string orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }
    public override string GetOrderStatus()
    {
        return $"Order delivered on {DeliveryDate.ToShortDateString()}. Tracking number: {TrackingNumber}";
    }
}
public class Program
{
    public static void Main()
    {
        DeliveredOrder deliveredOrder = new DeliveredOrder("ORD12345", DateTime.Now.AddDays(-5), "TRK98765", DateTime.Now);
        Console.WriteLine(deliveredOrder.GetOrderStatus());
        ShippedOrder shippedOrder = new ShippedOrder("ORD54321", DateTime.Now.AddDays(-10), "TRK12345");
        Console.WriteLine(shippedOrder.GetOrderStatus());
        Order order = new Order("ORD67890", DateTime.Now.AddDays(-15));
        Console.WriteLine(order.GetOrderStatus());
    }
}
