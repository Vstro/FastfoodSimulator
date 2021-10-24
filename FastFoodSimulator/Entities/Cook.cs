using System.Collections.Generic;
using System.Threading;
using FastFoodSimulator.Entities.Interfaces;

namespace FastFoodSimulator.Entities
{
    class Cook : ICook
    {
        public int OrderFulfilmentInterval { get; set; }
        public bool IsCooking { get; set; } = false;
        public IServer Server { get; set; }
        public IFastfoodSimulatorGUI GUI { get; set; }
        private Queue<IOrder> OrderQueue { get; set; } = new Queue<IOrder>();

        public void AddOrderToDo(IOrder order)
        {
            OrderQueue.Enqueue(order);
            GUI.NotifyNewWaitingCookingOrder(order.Number);
        }

        public void CookOrders()
        {
            while (IsCooking)
            {
                if (OrderQueue.Count > 0)
                {
                    IOrder order = OrderQueue.Dequeue();
                    GUI.NotifyStartedCookingNextOrder(order.Number);
                    Thread.Sleep(OrderFulfilmentInterval); // Cooking an order
                    GUI.NotifyFinishedCookingNextOrder();
                    Server.PlaceDoneOrder(order);
                }
            }
        }
    }
}
