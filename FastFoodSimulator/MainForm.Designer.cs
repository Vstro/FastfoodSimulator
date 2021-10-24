
namespace FastFoodSimulator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArrivalIntervalLabel = new System.Windows.Forms.Label();
            this.ArrivalIntervalTextBox = new System.Windows.Forms.TextBox();
            this.CookingIntervalLabel = new System.Windows.Forms.Label();
            this.CookingIntervalTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentlyTakenOrderLabel = new System.Windows.Forms.Label();
            this.OrdersWaitingCookingLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdersWaitingCookingAmountLabel = new System.Windows.Forms.Label();
            this.CookingOrderNumberLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderWaitingPickupLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WaitingCustomersAmountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrivalIntervalLabel
            // 
            this.ArrivalIntervalLabel.AutoSize = true;
            this.ArrivalIntervalLabel.Location = new System.Drawing.Point(12, 10);
            this.ArrivalIntervalLabel.Name = "ArrivalIntervalLabel";
            this.ArrivalIntervalLabel.Size = new System.Drawing.Size(283, 30);
            this.ArrivalIntervalLabel.TabIndex = 0;
            this.ArrivalIntervalLabel.Text = "Customer arrival interval (ms)";
            // 
            // ArrivalIntervalTextBox
            // 
            this.ArrivalIntervalTextBox.Location = new System.Drawing.Point(305, 9);
            this.ArrivalIntervalTextBox.Name = "ArrivalIntervalTextBox";
            this.ArrivalIntervalTextBox.Size = new System.Drawing.Size(121, 35);
            this.ArrivalIntervalTextBox.TabIndex = 1;
            // 
            // CookingIntervalLabel
            // 
            this.CookingIntervalLabel.AutoSize = true;
            this.CookingIntervalLabel.Location = new System.Drawing.Point(12, 48);
            this.CookingIntervalLabel.Name = "CookingIntervalLabel";
            this.CookingIntervalLabel.Size = new System.Drawing.Size(208, 30);
            this.CookingIntervalLabel.TabIndex = 2;
            this.CookingIntervalLabel.Text = "Cooking interval (ms)";
            // 
            // CookingIntervalTextBox
            // 
            this.CookingIntervalTextBox.Location = new System.Drawing.Point(305, 50);
            this.CookingIntervalTextBox.Name = "CookingIntervalTextBox";
            this.CookingIntervalTextBox.Size = new System.Drawing.Size(122, 35);
            this.CookingIntervalTextBox.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(452, 21);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(146, 57);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(626, 21);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(146, 57);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last taken order number: ";
            // 
            // CurrentlyTakenOrderLabel
            // 
            this.CurrentlyTakenOrderLabel.AutoSize = true;
            this.CurrentlyTakenOrderLabel.Location = new System.Drawing.Point(442, 131);
            this.CurrentlyTakenOrderLabel.Name = "CurrentlyTakenOrderLabel";
            this.CurrentlyTakenOrderLabel.Size = new System.Drawing.Size(21, 30);
            this.CurrentlyTakenOrderLabel.TabIndex = 7;
            this.CurrentlyTakenOrderLabel.Text = "-";
            // 
            // OrdersWaitingCookingLabel
            // 
            this.OrdersWaitingCookingLabel.AutoSize = true;
            this.OrdersWaitingCookingLabel.Location = new System.Drawing.Point(458, 236);
            this.OrdersWaitingCookingLabel.Name = "OrdersWaitingCookingLabel";
            this.OrdersWaitingCookingLabel.Size = new System.Drawing.Size(21, 30);
            this.OrdersWaitingCookingLabel.TabIndex = 9;
            this.OrdersWaitingCookingLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Orders waiting for cooking: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Orders waiting for cooking amount: ";
            // 
            // OrdersWaitingCookingAmountLabel
            // 
            this.OrdersWaitingCookingAmountLabel.AutoSize = true;
            this.OrdersWaitingCookingAmountLabel.Location = new System.Drawing.Point(534, 266);
            this.OrdersWaitingCookingAmountLabel.Name = "OrdersWaitingCookingAmountLabel";
            this.OrdersWaitingCookingAmountLabel.Size = new System.Drawing.Size(24, 30);
            this.OrdersWaitingCookingAmountLabel.TabIndex = 11;
            this.OrdersWaitingCookingAmountLabel.Text = "0";
            // 
            // CookingOrderNumberLabel
            // 
            this.CookingOrderNumberLabel.AutoSize = true;
            this.CookingOrderNumberLabel.Location = new System.Drawing.Point(427, 206);
            this.CookingOrderNumberLabel.Name = "CookingOrderNumberLabel";
            this.CookingOrderNumberLabel.Size = new System.Drawing.Size(21, 30);
            this.CookingOrderNumberLabel.TabIndex = 13;
            this.CookingOrderNumberLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cooking order number: ";
            // 
            // OrderWaitingPickupLabel
            // 
            this.OrderWaitingPickupLabel.AutoSize = true;
            this.OrderWaitingPickupLabel.Location = new System.Drawing.Point(458, 345);
            this.OrderWaitingPickupLabel.Name = "OrderWaitingPickupLabel";
            this.OrderWaitingPickupLabel.Size = new System.Drawing.Size(21, 30);
            this.OrderWaitingPickupLabel.TabIndex = 15;
            this.OrderWaitingPickupLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Order waiting for pickup: ";
            // 
            // WaitingCustomersAmountLabel
            // 
            this.WaitingCustomersAmountLabel.AutoSize = true;
            this.WaitingCustomersAmountLabel.Location = new System.Drawing.Point(458, 375);
            this.WaitingCustomersAmountLabel.Name = "WaitingCustomersAmountLabel";
            this.WaitingCustomersAmountLabel.Size = new System.Drawing.Size(24, 30);
            this.WaitingCustomersAmountLabel.TabIndex = 17;
            this.WaitingCustomersAmountLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Waiting customers amount: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "ORDER LINE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "KITCHEN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "SERVING LINE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WaitingCustomersAmountLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OrderWaitingPickupLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CookingOrderNumberLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrdersWaitingCookingAmountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrdersWaitingCookingLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentlyTakenOrderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CookingIntervalTextBox);
            this.Controls.Add(this.CookingIntervalLabel);
            this.Controls.Add(this.ArrivalIntervalTextBox);
            this.Controls.Add(this.ArrivalIntervalLabel);
            this.Name = "MainForm";
            this.Text = "Fastfood Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArrivalIntervalLabel;
        private System.Windows.Forms.TextBox ArrivalIntervalTextBox;
        private System.Windows.Forms.Label CookingIntervalLabel;
        private System.Windows.Forms.TextBox CookingIntervalTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentlyTakenOrderLabel;
        private System.Windows.Forms.Label OrdersWaitingCookingLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OrdersWaitingCookingAmountLabel;
        private System.Windows.Forms.Label CookingOrderNumberLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OrderWaitingPickupLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label WaitingCustomersAmountLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

