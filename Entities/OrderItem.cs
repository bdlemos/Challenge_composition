using System;

namespace Desafio.Entities{
    class OrderItem{
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem(){}
        public OrderItem(int quantity, Product product){
            Price = product.Price;
            Product = product;
            Quantity = quantity;
        }

        public double SubTotal(){
            return Price * Quantity;
        }
        public override string ToString()
        {
            return ($"{Product.Name}, ${Price:F2}, Quantity: {Quantity}, Subtotal: {SubTotal():F2}");
        }
    }
}