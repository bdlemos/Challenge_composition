using System;
using System.Collections.Generic;

namespace Desafio.Entities{
    class Order{
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public List<OrderItem> List_orders { get; set; } = new List<OrderItem>();
        
        //Constructors
        public Order(){}
        public Order(Client client, DateTime moment){
            Client = client;
            Moment = moment;
        }
        //Methods
        public void AddItem(OrderItem orderitem){
            List_orders.Add(orderitem);
        }
        public void RemoveItem(OrderItem orderitem){
            List_orders.Remove(orderitem);
        }
        public double Total(){
            sum = 0;
            foreach (var item in List_orders){
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}