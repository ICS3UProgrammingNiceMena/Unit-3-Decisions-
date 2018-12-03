
/*
 * Created by: Nice Mena
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - running average
 * This program calculates the average
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

namespace RunningAverageNiceM
{
    public partial class Form1 : Form
    {
        double total = 0;
        int numOfMarks = 0;
        double average = 0;
        double mark;
        int nextNumber;


        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

            // convert mark
            double mark = double.Parse(txtMark.Text);

            if (mark > 0 && mark < 100)
            {
                // create the total
                total = mark + total;

                // increment
                numOfMarks++;

                // calculate the average
                average = total / numOfMarks;

                // display the average
                lblAverage.Text = "your average is " + average + " % ";

            }

            else if (mark == -1)
            {
                // display the mark
                lblAverage.Text = "your average is " + average + " % ";
            }
            else
            {  // display message box if its a non proper value}
                MessageBox.Show("Please enter a valid value");







            }

        }
    }
}
