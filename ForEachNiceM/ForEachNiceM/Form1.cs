/*
 * Created by: Nice Mena
 * Created on: November 2nd 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Control Objects
 * This program changes the color of each object and its back color
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

namespace ForEachNiceM
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();

        }
        private void btnClickMe_Click_1(object sender, EventArgs e)
        {
            // changing the colour
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Yellow;
                this.BackColor = Color.YellowGreen;

                // if the object is a label change the color to pink
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.HotPink;
                }

            }
        }

        private void lblPlease_Click_1(object sender, EventArgs e)
        {
            // if the object is a button, make it yellow

            foreach (Control aControlObject in this.Controls)
                aControlObject.BackColor = Color.Red;
            this.BackColor = Color.Blue;

        }
    }
}
