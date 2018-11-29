/*
 * Created by: Nice Mena
 * Created on: november 1st 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program...
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

namespace FactorialDWNiceM
{
    public partial class FactoialDWForm : Form
    {
        public FactoialDWForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declare local variables
            double factorialAnswer;
            double factorialNumber;
            int factorialCounter;

            //clea the items in the listbox
            this.lstNumbers.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number fom the user 
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the counter by the next incremented number until it reaches the user's number
            do
            {
                // increment th counter by 1
                factorialCounter = factorialCounter + 1;

                // list the counter number in th listbox so the user can see it
                this.lstNumbers.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;



            } while (factorialCounter < factorialNumber);

            // Convert the factorial answer to a string and insert it into the label
            this.lblAnswer.Text = this.txtNumber.Text + " ! = " + Convert.ToString(factorialAnswer);

            
    }   }
}

