using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert1_Click(object sender, EventArgs e)
        {
            int input = 0;

            try
            { 
                input = Int32.Parse(txtToConvert.Text);
            } catch
            {
                txtConverted.Text = "NOT A NUMBER";
                return;
            }

            if (input > 3999)
            {
                txtConverted.Text = "NUMBER IS TOO BIG";
                return;
            }

            try
            {
                string[] thousands = { "", "M", "MM", "MMM" };
                string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] tenths = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
                string output = "";

                output += thousands[(int)(input / 1000) % 10];
                output += hundreds[(int)(input / 100) % 10];
                output += tenths[(int)(input / 10) % 10];
                output += ones[input % 10];

                txtConverted.Text = output.ToString();
            } catch
            {
                txtConverted.Text = "ERROR!";
                return;
            }

        }
    }
}
