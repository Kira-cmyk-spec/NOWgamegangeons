using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dANGEORS
{
    internal class Classstore
    {


        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }


            public Product(string name, decimal price)
            {
                Name = name;
                Price = price;

            }
        }

        class Purchase
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }

            public Purchase(string productName, int quantity, decimal totalPrice)
            {
                ProductName = productName;
                Quantity = quantity;
                TotalPrice = totalPrice;
            }
        }
    }
}
