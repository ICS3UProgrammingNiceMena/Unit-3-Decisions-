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
        private int nextNumber;

        public Form1()
        {
            InitializeComponent();

            int nextNumber;
            int Total;
            double Average;
            int Mark;
        }

        private void lblEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            // if the user enters -1, display a goodbye message
            
            else if (nextNumber == -1)
            {
                MessageBox.Show("Running Average Ended.", "Running Average");
                this.btnCalculate.Enabled = false;
                this.txtMark.Visible = false;

                // hide the label from the user
                this.lblAverage.Hide();



            }

    }   }        
}
