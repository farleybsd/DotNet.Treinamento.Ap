using AulaAp.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AulaAP.Domain.Entities
{
    public class Order : Entity<string>
    {
        public Order(int orderCode, ICollection<Product> products)
        {
            OrderCode = orderCode;
            Products = products;
        }

        public int OrderCode { get; private set; }
        public ICollection<Product> Products { get; private set; }
        public decimal TotalValue() => Products.Any() ? Products.Sum(p => p.Value * p.Quantity) : 0;
        public static string GenerateOrderCode()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmss") + new Random().Next(1,99999);
        }
    }
}
