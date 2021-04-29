using AulaAp.Domain.Shared;

namespace AulaAP.Domain.Entities
{
    public  class Product : Entity<string>
    {
        public Product(string name, decimal value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public int Quantity { get; private set; }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}