/*
 * Created by: Nice Mena
 * Created on:
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - pass by value
 * This program converts the temperature from celcius to farenheit
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

namespace PassByRefNiceM
{
    public partial class frmPassByValue : Form
    {
        public frmPassByValue()
        {
            InitializeComponent();
        }

        public void ConvertToFarenheit(double userCelcius)
        {
            // declare local variable
            double farenheit;

            // calculcate the temp in farenheit
            farenheit = userCelcius * 9/5 +32; 

            MessageBox.Show(" The temperature in Farenheit is " + farenheit + " degrees");
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            // declaring the local variables
            double userCelcius;
            

            // converting the inputed temperature  from string to double
            userCelcius = Convert.ToDouble(this.txtCelcius.Text);

            // calling the function to calculate the temperature passsing celcius value
            this.ConvertToFarenheit(userCelcius);
        }
    }
}