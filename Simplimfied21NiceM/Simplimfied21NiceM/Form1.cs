using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplimfied21NiceM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //hiding the winner or loser from the user
            this.lblWinnerOrLoser.Hide();

            // declaring global variables
            int pCard1 = 5 ;
            int pCard2 = 7 ;
            int pScore = 11 ;

            int dCard1 = 6 ;
            int dCard2 = 8 ;
            int dCard3 = 10;
            int dScore = 24;
                
            Random randomNumber;

            const int Min = 1;
            const int Max = 10;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnHit_Click(object sender, EventArgs e)
        {

        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            // deal cards to dealer, calculate score,


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
