using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGameNiceM
{
    public partial class GuessGameNiceM : Form
    {
        public GuessGameNiceM()
        {
            InitializeComponent();

            // hiding the laels and the pictures 
            lblAnswer.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declaring the variables
            int userGuess;
            const int CORRECTNUMBER = 3;

            // gET THE GUESS FROM THE TEXTBOX

            userGuess = int.Parse(txtGuess.Text);

            // if the guess 1 
            if (userGuess == CORRECTNUMBER);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudGuess_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
