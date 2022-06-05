using System;

namespace Desafio.Entities{
    class OrderItem{
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem(){}
        public OrderItem(string name, Product product){
            Name = name;
            Price = product.price;
            Product = product;
        }

        public double SubTotal(){
            return Price * Quantity;
        }
    }
}