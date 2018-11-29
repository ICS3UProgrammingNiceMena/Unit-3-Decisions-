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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // loop through each object on the fom ad make it green
            foreach (Control aControlObject in this.Controls);

        }

        private void lblPlease3_Click(object sender, EventArgs e)
        {
            // if the object is a button, make it yellow

            foreach (Control aControlObject in this.Controls) ;
 
            if (aControlObject.GetType() == typeof(Label));
            {
                lblPlease.BackColor = Color.Yellow;

            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
           
        }
    }
}
