namespace FastFoodSimulator.Entities.Interfaces
{
    interface IFastfoodSimulatorGUI
    {
        void NotifyOrderTaken(int orderNumber);
        void NotifyNewWaitingCookingOrder(int orderNumber);
        void NotifyStartedCookingNextOrder(int orderNumber);
        void NotifyFinishedCookingNextOrder();
        void NotifyNewWaitingCustomer();
        void NotifyDoneOrderServed(int orderNumber);
        void NotifyDoneOrderPickedUp();
    }
}
