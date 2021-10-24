namespace FastFoodSimulator.Entities.Interfaces
{
    interface ICustomer
    {
        int OrderNumber { get; set; }
        void MakeOrder<O>(IOrderTaker<O> orderTaker) where O : IOrder, new()
        {
            OrderNumber = orderTaker.TakeOrder();
        }
        void GoToServingLine(IServer server)
        {
            server.MeetCustomer(this);
        }
    }
}
