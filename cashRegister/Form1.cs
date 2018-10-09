using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister //how do you change zis? (the name)
{
    public partial class Form1 : Form
    {
        /*tip: start EASY. Do the easiest things first, then start
        your code off nice and slow, and expand on it
        like Mr. T says, basics are most important, worry about 
        aesthetics only if there's time*/

        //const double burgCost = 2.49("C"); //can't add the C
        //const double fryCost = 1.89("C");
        //const double drinkCost = 0.99("C");
        //const double taxRate = 0.13;

        double burgNumb = 0;
        double frynumb = 0;
        double drinknumb = 0;
        double totalCost = 0;
        double taxAmount = 0;
        double totalWithTax = 0;
        double tendAmount = 0;
        double changeAmount = 0;

        public Form1()
        {
            InitializeComponent();

            tendErrorLabel.Visible = false;
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 1);
            g.DrawRectangle(drawPen, 250, 63, 300, 335);


        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                changeAmount = Convert.ToInt16(tendBox.Text);
                tendErrorLabel.Visible = true;
                tendErrorLabel.Text = "Thank you!";

                /*totalPrice = basePrice + toppingNumber * pricePerTopping;
                outputLabel.Text = "With " + toppingNumber + " topping(s), your pizza comes to " +
                    totalPrice.ToString("C");*/
            }
            catch
            {
                tendErrorLabel.Visible = true;
                tendErrorLabel.Text = "Sorry, we accept cash only";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
