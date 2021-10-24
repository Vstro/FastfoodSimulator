namespace FastFoodSimulator.Entities.Interfaces
{
    interface IOrderTaker<O> where O : IOrder, new()
    {
        ICook Cook { get; set; }
        IFastfoodSimulatorGUI GUI { get; set; }
        int TakeOrder();
    }
}
