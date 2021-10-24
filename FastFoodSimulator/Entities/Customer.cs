using FastFoodSimulator.Entities.Interfaces;

namespace FastFoodSimulator.Entities
{
    class Customer : ICustomer
    {
        public int OrderNumber { get; set; }
    }
}
