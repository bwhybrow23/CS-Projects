using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Days_of_Christmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Days Array
        string[] days = new string[12] {
      "first",
      "second",
      "third",
      "fourth",
      "fifth",
      "sixth",
      "seventh",
      "eighth",
      "ninth",
      "tenth",
      "eleventh",
      "twelfth",
    };
        //Gifts Array
        string[] gifts = new string[12] {
      "A partridge in a pear tree",
      "Two turtle doves",
      "Three french hens",
      "Four calling birds",
      "Five golden rings",
      "Six geese a-laying",
      "Seven swans a-swimming",
      "Eight maids a-milking",
      "Nine ladies dancing",
      "Ten lords a-leaping",
      "Eleven pipers piping",
      "Twelve drummers drumming"
    };

        private void btn_go_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                rtb_result.AppendText("On the " + days[i] + " day of Christmas, my true love gave to me");

                int j = i + 1;
                while (j-- > 0)
                {
                    rtb_result.AppendText("\r\n" + gifts[j]);
                }
                rtb_result.AppendText("\r\n\n");

                if (i == 0)
                {
                    gifts[0] = "And a partridge in a pear tree";
                }
            }

        }

    }
}