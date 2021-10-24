namespace FastFoodSimulator.Entities.Interfaces
{
    interface ICustomerGenerator<C, O> where C : ICustomer, new() where O : IOrder, new()
    {
        int CustomerArrivalInterval { get; set; }
        bool IsWorking { get; set; }
        IOrderTaker<O> OrderTaker { get; set; }
        IServer Server { get; set; }
        void GenerateCustomers();
    }
}
