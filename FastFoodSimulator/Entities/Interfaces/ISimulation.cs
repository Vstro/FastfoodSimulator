namespace FastFoodSimulator.Entities.Interfaces
{
    interface ISimulation<CustomerGenerator, Cook, OrderTaker, Server, C, O> 
        where CustomerGenerator : ICustomerGenerator<C, O>, new()
        where Cook : ICook, new()
        where OrderTaker : IOrderTaker<O>, new()
        where Server : IServer, new()
        where O : IOrder, new()
        where C : ICustomer, new()
    {
        CustomerGenerator CustomerGeneratorInstance { get; set; }
        Cook CookInstance { get; set; }
        OrderTaker OrderTakerInstance { get; set; }
        Server ServerInstance { get; set; }
        IFastfoodSimulatorGUI GUI { get; set; }

        void Initialize(IFastfoodSimulatorGUI gui);
        void Start(int arrivalInterval, int cookingInterval);
        void Stop();
    }
}
