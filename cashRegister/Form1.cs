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

        double burgTotal;
        double fryTotal;
        double drinkTotal;

        double totalCost = 0;
        double taxAmount = 0;
        double totalWithTax = 0;
        double tendAmount = 0;
        double changeAmount = 0;

        //don't forget to add comments, btw...

        public Form1()
        {
            InitializeComponent();

            subTotDisplayLabel.Text = null;
            taxDisplayLabel.Text = null;
            totalDisplayLabel.Text = null;
            calcChangeLabel.Text = null;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                calcErrorLabel.Text = null;

                burgNumb = Convert.ToDouble(burgBox.Text);
                fryNumb = Convert.ToDouble(fryBox.Text);
                drinkNumb = Convert.ToDouble(drinkBox.Text);

                burgTotal = BURGER_COST * burgNumb;
                fryTotal = FRY_COST * fryNumb;
                drinkTotal = DRINK_COST * drinkNumb;

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
                tendAmount = Convert.ToDouble(tendBox.Text);
                changeAmount = Convert.ToDouble(tendBox.Text);
                changeAmount = tendAmount - totalWithTax;
                calcChangeLabel.Text = changeAmount.ToString("C");
                tendErrorLabel.Text = "Thank you!";
            }
            catch
            {
                tendErrorLabel.Text = "Sorry, we accept cash only";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 1);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawRectangle(drawPen, 242, 51, 300, 335);
            g.FillRectangle(drawBrush, 243, 52, 299, 334);

            drawBrush.Color = Color.Black;
            Font drawFont = new Font("Arial", 8, FontStyle.Regular);
            g.DrawString("Generic Food Place Inc.", drawFont, drawBrush, 250, 56);

            /* EXAMPLE: "With " + toppingNumber + " topping(s), your pizza comes to " +
                    totalPrice.ToString("C"); */

            //remember, with strings, you can have everything in the same line, you don't need 
            //to make separate strings. This might make things simpler for you, I don't know.
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //when this button is pushed, clear all on-screen input
            burgBox.Text = null;
            fryBox.Text = null;
            drinkBox.Text = null;
            calcChangeLabel.Text = null;
            subTotDisplayLabel.Text = null;
            taxDisplayLabel.Text = null;
            totalDisplayLabel.Text = null;
            tendBox.Text = null;
            tendErrorLabel.Text = null;
            calcChangeLabel.Text = null;

            //remember to reset your variables too!

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
