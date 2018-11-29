using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperSciNiceM
{
    public partial class RockPaperSciForm : Form
    {
        // declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;

        Random randomNumberGenerator;


        public RockPaperSciForm()
        {
            InitializeComponent();

            // raete random nuber generator object 
            randomNumberGenerator = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declare local vaiables
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;


            // get the user's selecion, if the selection is set to 0 
            if (radRockUser.Checked == true)
            {
                playerChoice = ROCK;
            }

            else if (radPaperUser.Checked == true)
            {
                playerChoice = PAPER
            }
            else if (radScissorsUser.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            // RANDOMLY GENERATE A NUMBER BETWEEN 1 AND 3, REPRESENTING ROCK, PAPER, SCISSORS



        }
    }
}
