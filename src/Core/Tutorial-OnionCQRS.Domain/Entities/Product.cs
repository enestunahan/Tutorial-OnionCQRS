using Tutorial_OnionCQRS.Domain.Common;

namespace Tutorial_OnionCQRS.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }    
        public decimal Value { get; set; }
        public int Quantity { get; set; }   
    }
}
