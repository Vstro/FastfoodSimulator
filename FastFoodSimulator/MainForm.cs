using System;
using System.Linq;
using System.Windows.Forms;
using FastFoodSimulator.Entities;
using FastFoodSimulator.Entities.Interfaces;

namespace FastFoodSimulator
{
    public partial class MainForm : Form, IFastfoodSimulatorGUI
    {
        ISimulation<
            CustomerGenerator<Customer, Order>, 
            Cook, 
            OrderTaker<Order>, 
            Server, 
            Customer, 
            Order> 
            Simulation = new Simulation<
                CustomerGenerator<Customer, Order>, 
                Cook, 
                OrderTaker<Order>, 
                Server, 
                Customer, 
                Order>();
        public MainForm()
        {
            InitializeComponent();
            Simulation.Initialize(this);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ArrivalIntervalTextBox.Text, out int arrivalInterval) || arrivalInterval < 0)
            {
                MessageBox.Show("Please, input positive integer as Arrival interval!", "Input Validation Error");
                return;
            }
            if (!int.TryParse(CookingIntervalTextBox.Text, out int cookingInterval) || cookingInterval < 0)
            {
                MessageBox.Show("Please, input positive integer as Cooking interval!", "Input Validation Error");
                return;
            }
            Simulation.Start(arrivalInterval, cookingInterval);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Simulation.Stop();
        }

        public void NotifyOrderTaken(int orderNumber)
        {
            // Notifying thread invokes action on main (UI) thread (because it doesn't have access to UI controls of another thread itself)
            CurrentlyTakenOrderLabel.Invoke((Action)delegate
            {
                CurrentlyTakenOrderLabel.Text = orderNumber.ToString();
            });
        }

        public void NotifyNewWaitingCookingOrder(int orderNumber)
        {
            // Notifying thread invokes action on main (UI) thread
            OrdersWaitingCookingLabel.Invoke((Action)delegate
            {
                if (OrdersWaitingCookingLabel.Text.Equals("-"))
                {
                    OrdersWaitingCookingLabel.Text = orderNumber.ToString();
                }
                else
                {
                    OrdersWaitingCookingLabel.Text += ", " + orderNumber;
                }
                OrdersWaitingCookingAmountLabel.Text = (int.Parse(OrdersWaitingCookingAmountLabel.Text) + 1).ToString();
            });    
        }

        public void NotifyStartedCookingNextOrder(int orderNumber)
        {
            // Notifying thread invokes action on main (UI) thread
            CookingOrderNumberLabel.Invoke((Action)delegate
            {
                CookingOrderNumberLabel.Text = orderNumber.ToString();
                if (!OrdersWaitingCookingLabel.Text.Contains(","))
                {
                    OrdersWaitingCookingLabel.Text = "-";
                }
                else
                {
                    OrdersWaitingCookingLabel.Text = OrdersWaitingCookingLabel.Text
                    .Split(',')
                    .Select(s => s.Trim())
                    .SkipWhile(num => int.Parse(num) <= orderNumber)
                    .DefaultIfEmpty("-")
                    .Aggregate((s1, s2) => s1 + ", " + s2);
                }
                OrdersWaitingCookingAmountLabel.Text = (int.Parse(OrdersWaitingCookingAmountLabel.Text) - 1).ToString();
            });
        }

        public void NotifyFinishedCookingNextOrder()
        {
            // Notifying thread invokes action on main (UI) thread
            CookingOrderNumberLabel.Invoke((Action)delegate
            {
                CookingOrderNumberLabel.Text = "-";
            });
        }

        public void NotifyNewWaitingCustomer()
        {
            // Notifying thread invokes action on main (UI) thread
            WaitingCustomersAmountLabel.Invoke((Action)delegate
            {
                WaitingCustomersAmountLabel.Text = (int.Parse(WaitingCustomersAmountLabel.Text) + 1).ToString();
            });
        }

        public void NotifyDoneOrderServed(int orderNumber)
        {
            // Notifying thread invokes action on main (UI) thread
            OrderWaitingPickupLabel.Invoke((Action)delegate
            {
                OrderWaitingPickupLabel.Text = orderNumber.ToString();
            });
        }

        public void NotifyDoneOrderPickedUp()
        {
            // Notifying thread invokes action on main (UI) thread
            WaitingCustomersAmountLabel.Invoke((Action)delegate
            {
                WaitingCustomersAmountLabel.Text = (int.Parse(WaitingCustomersAmountLabel.Text) - 1).ToString();
                OrderWaitingPickupLabel.Text = "-";
            });
        }
    }
}
