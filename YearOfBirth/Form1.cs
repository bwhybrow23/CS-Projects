using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearOfBirth
{
    public partial class YearOfBirth : Form
    {
        public YearOfBirth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age;
            bool HadBirthday;
            int YearOfBirth;
            int Year;
            Year = DateTime.Now.Year;

            Age = Int32.Parse(txtAge.Text);
            HadBirthday = chkHadBirthday.Checked;

            if ((Age >= 1) && (Age <= 120))
            {
                if (HadBirthday)
                {
                    YearOfBirth = Year - Age;
                } else
                {
                    YearOfBirth = (Year - Age) - 1;
                }
            } else
            {
                YearOfBirth = 0;
            }

            lblOutput.Text = YearOfBirth.ToString();

        }
    }
}
