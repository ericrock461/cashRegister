using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class Form1 : Form
    {
        /*tip: start EASY. Do the easiest things first, then start
        your code off nice and slow, and expand on it
        like Mr. T says, basics are most important, worry about 
        aesthetics only if there's time*/

        const double BURGER_COST = 2.49;
        const double FRY_COST = 1.89;
        const double DRINK_COST = 0.99;
        const double TAX_RATE = 0.13;

        double burgNumb = 0;
        double fryNumb = 0;
        double drinkNumb = 0;
        double totalCost = 0;
        double taxAmount = 0;
        double totalWithTax = 0;
        double tendAmount = 0;
        double changeAmount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 1);
            g.DrawRectangle(drawPen, 250, 63, 300, 335);

            //g.drawString "all the stuff you need"

        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                calcErrorLabel.Text = null;

                burgNumb = Convert.ToDouble(burgBox.Text);
                fryNumb = Convert.ToDouble(fryBox.Text);
                drinkNumb = Convert.ToDouble(drinkBox.Text);

                double burgTotal = BURGER_COST * burgNumb;
                double fryTotal = FRY_COST * fryNumb;
                double drinkTotal = DRINK_COST * drinkNumb;
                totalCost = burgTotal + fryTotal + drinkTotal;

                subTotDisplayLabel.Text = totalCost.ToString("C");
                taxAmount = totalCost * 0.13;
                taxDisplayLabel.Text = taxAmount.ToString("C");

                totalWithTax = taxAmount + totalCost;
                totalDisplayLabel.Text = totalWithTax.ToString("C");
            }
            catch
            {
                calcErrorLabel.Text = "Numerical values only"; 
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                changeAmount = Convert.ToInt16(tendBox.Text);
                //changeAmount = tendBox.Text - totalWithTax;
                tendErrorLabel.Text = "Thank you!";

                /*totalPrice = basePrice + toppingNumber * pricePerTopping;
                outputLabel.Text = "With " + toppingNumber + " topping(s), your pizza comes to " +
                    totalPrice.ToString("C");*/
            }
            catch
            {
                tendErrorLabel.Text = "Sorry, we accept cash only";
                //thank yo- wait a minute... that's not enough (not enough money)
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //oops
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //nevermind this here
        }
    }
}
