using System;
using System.Globalization;
using Desafio.Entities;

namespace Desafio{
    class Desafio{
        static void Main(){
            CultureInfo provider = CultureInfo.InvariantCulture;
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);
            // Register Client
            System.Console.WriteLine("Enter client Data: ");
            System.Console.Write("Name: ");
            string? name = Console.ReadLine();
            System.Console.Write("Email: ");
            string? email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthday);

            // Order
            Order order = new Order(client, DateTime.Now);
            System.Console.WriteLine("Enter order data: ");
            order.Status = (OrderStatus)1;
            System.Console.WriteLine("Status: " + order.Status);
            System.Console.Write("How many items to this order: ");
            int num_of_items = Convert.ToInt32(Console.ReadLine());

            //Each item
            for (int i = 0; i < num_of_items; i++){
                System.Console.WriteLine($"Enter #{i+1} item data:");
                System.Console.Write("Product name: ");
                string nameitem = Console.ReadLine();
                System.Console.Write("Product Price: ");
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Quantinty: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Product p = new Product(nameitem, price);
                OrderItem item = new OrderItem(quantity, p);
                order.AddItem(item);
            }

            // Order Summary

            System.Console.WriteLine("Order moment: " + order.Moment);
            System.Console.WriteLine("Order status: " + order.Status);
            System.Console.WriteLine("Client: " + order.Client);
            System.Console.WriteLine("Order items: ");
            foreach (var item in order.List_orders){
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine($"Total price : ${order.Total():F2}");
        }
    }

}