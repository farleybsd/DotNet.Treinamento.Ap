using AulaAp.Domain.Shared;

namespace AulaAP.Domain.Entities
{
    public abstract class Product : Entity<string>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}