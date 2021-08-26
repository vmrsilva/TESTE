using ConsoleApp4.Entities;
using ConsoleApp4.Entities.Enums;
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os;
            Enum.TryParse("Delivered", out os);              // teste 1

            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");    //teste2

            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");  // teste3
        }
    }
}