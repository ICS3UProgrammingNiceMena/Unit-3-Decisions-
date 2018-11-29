/*
 * Created by: First Last
 * Created on: Ocober 24th 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Name of Program
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

namespace PefectSquareNiceM
{
    public partial class frmPerfectSquare : Form
    {
        public frmPerfectSquare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // declare local vaiables
            int endingValue;
            int value;
            double squareRootAsDouble;
            int squareRootAsInteger;

            // set iniial values
            value = 1;


           // clear all items
            this.lstBox.Items.Clear();

            //get the user's end value selection fom the number up-down 
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            // continue stating an perfect squares
            while (value<= endingValue)
            {
                // take the square oo of the value
                squareRootAsDouble = Math.Sqrt(value);
                // convert double to integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // the only way for a decimal and integer to equal if the value is not a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstBox.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
                value = value + 1;


            }



      
        }
    }
}
