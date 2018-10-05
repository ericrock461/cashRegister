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


        public Form1()
        {
            InitializeComponent();
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 1);
            g.DrawRectangle(drawPen, 250, 63, 300, 335);

        }
    }
}
