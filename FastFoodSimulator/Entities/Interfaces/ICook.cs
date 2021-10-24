namespace FastFoodSimulator.Entities.Interfaces
{
    interface ICook
    {
        int OrderFulfilmentInterval { get; set; }
        bool IsCooking { get; set; }
        IServer Server { get; set; }
        IFastfoodSimulatorGUI GUI { get; set; }
        void CookOrders();
        void AddOrderToDo(IOrder order);
    }
}
