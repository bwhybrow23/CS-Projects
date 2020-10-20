using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenBottles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int number;
            int counter;
            string song;

            song = "";

            number = Int32.Parse(txtInput.Text);

            for (counter = number; counter > 0; counter = counter - 1)
            {
                song = song + counter.ToString() + " green bottles sitting on the wall\n";
                song = song + counter.ToString() + " green bottles sitting on the wall\n";
                song = song + "and if one green bottle should accidently fall\n";
                song = song + "there'll be " + (counter - 1).ToString() + " green bottles sitting on the wall\n\n";
            }

            rtbOutput.Text = song;
        }
    }
}
