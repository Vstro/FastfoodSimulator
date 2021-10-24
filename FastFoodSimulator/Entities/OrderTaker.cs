using FastFoodSimulator.Entities.Interfaces;

namespace FastFoodSimulator.Entities
{
    class OrderTaker<O> : IOrderTaker<O> where O : IOrder, new()
    {
        public ICook Cook { get; set; }
        public IFastfoodSimulatorGUI GUI { get; set; }
        private static int NextOrderNumber { get; set; } = 0;

        public int TakeOrder()
        {
            IOrder order = new O() { Number = NextOrderNumber };
            GUI.NotifyOrderTaken(NextOrderNumber);
            Cook.AddOrderToDo(order);
            return NextOrderNumber++;
        }
    }
}
