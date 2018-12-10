using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeNiceM
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare variables
            int counter;
            const int MAXNUMBER = 90, MINNUMBER = 65;
            string character;

            //clear list box
            this.lstNumbers.Items.Clear();

            // displaying the content
            for (counter = MINNUMBER; counter <= MAXNUMBER; counter++)
            {
                character = char.ConvertFromUtf32(counter);
                lstNumbers.Items.Add(character + "->" + counter);
            }
        


        }
    }
}
