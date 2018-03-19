/*
 * Created by: Jadon Fournier
 * Created on: 19-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program allows you to enter the number of boxes you sold, and tells you the prize you get.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxes
{
    public partial class Form1 : Form
    {
        //Set variables.
        int numBoxes;

        public Form1()
        {
            InitializeComponent();
            this.lblAnswer.Hide();
        }

        private void nudInput_ValueChanged(object sender, EventArgs e)
        {
            numBoxes = (int)nudInput.Value;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (numBoxes > 9)
            {
                if (numBoxes > 19)
                {
                    lblAnswer.Text = "You get a prize!";
                }

                else
                {
                    lblAnswer.Text = "You get a small prize.";
                }
            }

            else
            {
                lblAnswer.Text = "You get an honourable mention.";
            }
            this.lblAnswer.Show();
        }
    }
}
