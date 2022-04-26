using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewsD_MidTerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            try
            {

                // Calculates and displays total expenses and determines whether or not a non-number was used.

                double rent;

                double lightBill;

                double cable;

                double carPayment;

                double insurance;

                double grocery;

                double misc;

                double totalExpenses;

                rent = double.Parse(rentInput.Text);

                lightBill = double.Parse(lightBillInput.Text);

                cable = double.Parse(cableInput.Text);

                carPayment = double.Parse(carPaymentInput.Text);

                insurance = double.Parse(insuranceInput.Text);

                grocery = double.Parse(groceryInput.Text);

                misc = double.Parse(miscInput.Text);

                totalExpenses = rent + lightBill + cable + carPayment + insurance + grocery + misc;

                totalExpOutput.Text = "$" + totalExpenses;
            }

            catch (Exception)
            {
                MessageBox.Show("Invalid data was entered!");
            }

            // Calculate the over/under amounts for each bill and displays the amounts to the over/under box.

            double rent1;

            double lightBill1;

            double cable1;

            double carPayment1;

            double insurance1;

            double grocery1;

            double misc1;

            double rent_OU;

            double lightBill_OU;

            double cable_OU;

            double carPayment_OU;

            double insurance_OU;

            double grocery_OU;

            double misc_OU;

            double overUnderTotal;

            rent1 = double.Parse(rentInput.Text);

            lightBill1 = double.Parse(lightBillInput.Text);

            cable1 = double.Parse(cableInput.Text);

            carPayment1 = double.Parse(carPaymentInput.Text);

            insurance1 = double.Parse(insuranceInput.Text);

            grocery1 = double.Parse(groceryInput.Text);

            misc1 = double.Parse(miscInput.Text);

            rent_OU = rent1 - 775.00;

            rentOutput.Text = "$" + rent_OU;

            lightBill_OU = lightBill1 - 275.00;

            lightBillOutput.Text = "$" + lightBill_OU;

            cable_OU = cable1 - 60.50;

            cableOutput.Text = "$" + cable_OU;

            carPayment_OU = carPayment1 - 325.00;

            carPaymentOutput.Text = "$" + carPayment_OU;

            insurance_OU = insurance1 - 125.76;

            insuranceOutput.Text = "$" + insurance_OU;

            grocery_OU = grocery1 - 300.00;

            groceryOutput.Text = "$" + grocery_OU;

            misc_OU = misc1 - 100.00;

            miscOutput.Text = "$" + misc_OU;

            //The following code will display whether the budget is over or under
            //and by how much.

            overUnderTotal = rent_OU + lightBill_OU + cable_OU + carPayment_OU + insurance_OU + grocery_OU + misc_OU;

            if (overUnderTotal > 0)
             {
                calculateOutput.Text = "You are over budget by: " + overUnderTotal;
             }
            else
             {
                calculateOutput.Text = "You are under budget by: " + overUnderTotal;
             }

            if (overUnderTotal == 0)
             {
                calculateOutput.Text = "Your budget equals your expenses.";
             }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //This code will clear all input and output text.

            rentInput.Text = "";
            rentOutput.Text = "";

            lightBillInput.Text = "";
            lightBillOutput.Text = "";

            cableInput.Text = "";
            cableOutput.Text = "";

            carPaymentInput.Text = "";
            carPaymentOutput.Text = "";

            insuranceInput.Text = "";
            insuranceOutput.Text = "";

            groceryInput.Text = "";
            groceryOutput.Text = "";

            miscInput.Text = "";
            miscOutput.Text = "";

            totalExpOutput.Text = "";

            calculateOutput.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            //This terminates the program.

            this.Close();
        }
    }
}
