namespace FastFoodSimulator.Entities.Interfaces
{
    interface IServer
    {
        bool IsServing { get; set; }
        IFastfoodSimulatorGUI GUI { get; set; }
        void PlaceDoneOrder(IOrder order);
        void MeetCustomer(ICustomer customer);
        void Serve();
    }
}
