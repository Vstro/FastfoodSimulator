using System.Collections.Generic;
using System.Threading;
using FastFoodSimulator.Entities.Interfaces;

namespace FastFoodSimulator.Entities
{
    class Server : IServer
    {
        private List<ICustomer> WaitingCustomers { get; set; } = new List<ICustomer>();
        private Queue<IOrder> DoneOrders { get; set; } = new Queue<IOrder>();
        public bool IsServing { get; set; }
        public IFastfoodSimulatorGUI GUI { get; set; }
        // Not instant pickup for better visibility
        private const int PICKUP_DELAY = 100;

        public void Serve()
        {
            while (IsServing)
            {
                if (DoneOrders.Count > 0)
                {
                    IOrder order = DoneOrders.Dequeue();
                    GUI.NotifyDoneOrderServed(order.Number);
                    ICustomer customer = WaitingCustomers
                        .Find(c => c.OrderNumber == order.Number);
                    if (customer != null)
                    {
                        Thread.Sleep(PICKUP_DELAY);
                        WaitingCustomers.Remove(customer);
                        GUI.NotifyDoneOrderPickedUp();
                    }
                }
            }
        }

        public void MeetCustomer(ICustomer customer)
        {
            WaitingCustomers.Add(customer);
            GUI.NotifyNewWaitingCustomer();
        }

        public void PlaceDoneOrder(IOrder order)
        {
            DoneOrders.Enqueue(order);
        }
    }
}
