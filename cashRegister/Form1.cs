using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/* 
 Erich Rock
 October 12, 2018
 Program for an interative cash register program
 */

namespace cashRegister
{
    public partial class Form1 : Form
    {
        //initialize all variables/constants
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

        public Form1()
        {
            InitializeComponent();

            //start with no text in the labels
            subTotDisplayLabel.Text = null;
            taxDisplayLabel.Text = null;
            totalDisplayLabel.Text = null;
            calcChangeLabel.Text = null;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //when button is pressed, do the following, and display costs and taxes
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
                //if an error occurs, a label with display an error message
                calcErrorLabel.Text = "Numerical values only"; 
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //when button is pushed, do the following
                tendAmount = Convert.ToDouble(tendBox.Text);
                changeAmount = Convert.ToDouble(tendBox.Text);
                changeAmount = tendAmount - totalWithTax;
                calcChangeLabel.Text = changeAmount.ToString("C");
                tendErrorLabel.Text = "Thank you!";
            }
            catch
            {
                //if an error occurs here, a different label will display a message
                tendErrorLabel.Text = "Sorry, we accept cash only";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //when button is clicked, draw in the receipt and print on it
            //all the information about the customer's order, including item prices and costs
            //play sounds during this

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 1);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawRectangle(drawPen, 242, 51, 300, 335);
            g.FillRectangle(drawBrush, 243, 52, 299, 334);

            drawBrush.Color = Color.Black;
            Font drawFont = new Font("Arial", 10, FontStyle.Regular);

            g.DrawString("Generic Food Place Inc.", drawFont, drawBrush, 324, 70);
            SoundPlayer player = new SoundPlayer(Properties.Resources.laserSound);
            Thread.Sleep(1000);
            player.Play();
            g.DrawString("Order Number 9,999", drawFont, drawBrush, 250, 100);
            Thread.Sleep(1000);
            g.DrawString("October 12, 2018", drawFont, drawBrush, 250, 120);
            Thread.Sleep(1000);

            g.DrawString("Hamburgers", drawFont, drawBrush, 250, 150);
            g.DrawString("x" + burgNumb + " @ " + BURGER_COST, drawFont, drawBrush, 400, 150);
            Thread.Sleep(1000);
            g.DrawString("Fries", drawFont, drawBrush, 250, 170);
            g.DrawString("x" + fryNumb + " @ " + FRY_COST, drawFont, drawBrush, 400, 170);
            Thread.Sleep(1000);
            g.DrawString("Drinks", drawFont, drawBrush, 250, 190);
            g.DrawString("x" + drinkNumb + " @ " + DRINK_COST, drawFont, drawBrush, 400, 190);
            Thread.Sleep(1000);

            g.DrawString("Subtotal               " + totalCost.ToString("C"), drawFont, drawBrush, 250, 220);
            Thread.Sleep(1000);
            g.DrawString("Tax                      " + taxAmount.ToString("C"), drawFont, drawBrush, 250, 240);
            Thread.Sleep(1000);
            g.DrawString("Total                    " + totalWithTax.ToString("C"), drawFont, drawBrush, 250, 260);
            Thread.Sleep(1000);

            g.DrawString("Tendered               " + tendAmount.ToString("C"), drawFont, drawBrush, 250, 290);
            Thread.Sleep(1000);
            g.DrawString("Change                 " + changeAmount.ToString("C"), drawFont, drawBrush, 250, 310);
            Thread.Sleep(1000);

            g.DrawString("Have a Great Day!!", drawFont, drawBrush, 250, 350);
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //when this button is activated, clear all on-screen input
            //including all info printed in the receipt

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 1);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.FillRectangle(drawBrush, 243, 52, 299, 334);

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

            //reset all variables back to zero
            burgNumb = 0;
            fryNumb = 0;
            drinkNumb = 0;
            totalCost = 0;
            taxAmount = 0;
            totalWithTax = 0;
            tendAmount = 0;
            changeAmount = 0;
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
