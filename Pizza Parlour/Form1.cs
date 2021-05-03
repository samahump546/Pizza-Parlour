using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class pizzaParlour : Form
    {
        //global varriables
        double basePrice = 7.00;
        double toppings = 1.25;
        double toppingsNumber;
        double totalPrice;
        public pizzaParlour()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            toppingsNumber = Convert.ToDouble(toppingsInput.Text);
            totalPrice = basePrice + toppings * toppingsNumber;

            priceInput.Text = $"The price of the pizza with {toppingsNumber} toppings is: \n\n${totalPrice}";
        }
    }
}
