using System.Threading;
using FastFoodSimulator.Entities.Interfaces;

namespace FastFoodSimulator.Entities
{
    class Simulation<CustomerGenerator, Cook, OrderTaker, Server, C, O> : ISimulation<CustomerGenerator, Cook, OrderTaker, Server, C, O>
        where CustomerGenerator : ICustomerGenerator<C, O>, new()
        where Cook : ICook, new()
        where OrderTaker : IOrderTaker<O>, new()
        where Server : IServer, new()
        where O : IOrder, new()
        where C : ICustomer, new()
    {
        public CustomerGenerator CustomerGeneratorInstance { get; set; }
        public Cook CookInstance { get; set; }
        public OrderTaker OrderTakerInstance { get; set; }
        public Server ServerInstance { get; set; }
        public IFastfoodSimulatorGUI GUI { get; set; }

        public void Initialize(IFastfoodSimulatorGUI gui)
        {
            CustomerGeneratorInstance = new CustomerGenerator();
            CookInstance = new Cook();
            OrderTakerInstance = new OrderTaker();
            ServerInstance = new Server();
            GUI = gui;

            CustomerGeneratorInstance.OrderTaker = OrderTakerInstance;
            CustomerGeneratorInstance.Server = ServerInstance;
            CookInstance.Server = ServerInstance;
            OrderTakerInstance.Cook = CookInstance;
            CookInstance.GUI = GUI;
            OrderTakerInstance.GUI = GUI;
            ServerInstance.GUI = GUI;
        }

        public void Start(int arrivalInterval, int cookingInterval)
        {
            CustomerGeneratorInstance.CustomerArrivalInterval = arrivalInterval;
            CookInstance.OrderFulfilmentInterval = cookingInterval;
            CustomerGeneratorInstance.IsWorking = true;
            CookInstance.IsCooking = true;
            ServerInstance.IsServing = true;
            Thread customerGeneratorThread = new Thread(CustomerGeneratorInstance.GenerateCustomers);
            Thread cookThread = new Thread(CookInstance.CookOrders);
            Thread serverThread = new Thread(ServerInstance.Serve);
            customerGeneratorThread.Start();
            cookThread.Start();
            serverThread.Start();
        }

        public void Stop()
        {
            CustomerGeneratorInstance.IsWorking = false;
            CookInstance.IsCooking = false;
            ServerInstance.IsServing = false;
        }
    }
}
