using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Rick" && txtPassword.Text == "Astley")
            {
                // The right password
                txtResult.Text = "Correct credentials, logging you in!";
            } else
            {
                // The incorrect password
                txtResult.Text = "Incorrect credentials";
            }
        }
    }
}
