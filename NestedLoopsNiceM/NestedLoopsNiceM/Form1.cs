/*
 * Created by: Nice Mena 
 * Created on: Novembr 5th
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
 * This program lists upper case letters next to lowercase next to it
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
namespace NestedLoopsNiceM
{
    public partial class frmNestedLoops : Form
    {
        public object A { get; private set; }

        public frmNestedLoops()
        {
            InitializeComponent();
           
        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
          // declare variables
          int counter1, counter2;
            string upperCaseLetters, lowerCaseLetters;

            for (counter1 = 65; counter1 <= 90; counter1++)
            {
                upperCaseLetters = Char.ConvertFromUtf32(counter1);

                for (counter2 = 97; counter2 <= 122; counter2++ )
                {
                    lowerCaseLetters = Char.ConvertFromUtf32(counter2);

                    this.lstLetters.Items.Add(upperCaseLetters + " --> " + lowerCaseLetters);
                }
            }
                
        }
    }
}
