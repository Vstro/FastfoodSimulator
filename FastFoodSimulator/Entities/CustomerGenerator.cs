using System.Threading;
using FastFoodSimulator.Entities.Interfaces;

namespace FastFoodSimulator.Entities
{
    class CustomerGenerator<C, O> : ICustomerGenerator<C, O> 
        where C : ICustomer, new() 
        where O : IOrder, new()
    {
        public int CustomerArrivalInterval { get; set; }
        public bool IsWorking { get; set; } = false;
        public IOrderTaker<O> OrderTaker { get; set; }
        public IServer Server { get; set; }

        public void GenerateCustomers()
        {
            while (IsWorking)
            {
                Thread.Sleep(CustomerArrivalInterval); // Waiting for a customer
                ICustomer customer = new C();
                customer.MakeOrder(OrderTaker);
                customer.GoToServingLine(Server);
            }
        }
    }
}
