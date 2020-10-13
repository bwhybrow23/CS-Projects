using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            string myText;

            myText = txtFirst.Text + txtSecond.Text;

            txtAnswer.Text = myText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float firstNum;
            float secondNum;
            float answer;

            try
            {
                firstNum = float.Parse(txtFirst.Text);
                secondNum = float.Parse(txtSecond.Text);
            }
            catch
            {
                txtAnswer.Text = "Not valid data.";
                return;
            }

            answer = firstNum + secondNum;

            txtAnswer.Text = answer.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            float firstNum;
            float secondNum;
            float answer;

            try
            {
                firstNum = float.Parse(txtFirst.Text);
                secondNum = float.Parse(txtSecond.Text);
            }
            catch
            {
                txtAnswer.Text = "Not valid data.";
                return;
            }

            answer = firstNum - secondNum;

            txtAnswer.Text = answer.ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            float firstNum;
            float secondNum;
            float answer;

            try
            {
                firstNum = float.Parse(txtFirst.Text);
                secondNum = float.Parse(txtSecond.Text);
            }
            catch
            {
                txtAnswer.Text = "Not valid data.";
                return;
            }

            answer = firstNum * secondNum;

            txtAnswer.Text = answer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float firstNum;
            float secondNum;
            float answer;

            try
            {
                firstNum = float.Parse(txtFirst.Text);
                secondNum = float.Parse(txtSecond.Text);
            }
            catch
            {
                txtAnswer.Text = "Not valid data.";
                return;
            }

            answer = firstNum / secondNum;

            txtAnswer.Text = answer.ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            float firstNum;
            float secondNum;
            float answer;

            try
            {
                firstNum = float.Parse(txtFirst.Text);
                secondNum = float.Parse(txtSecond.Text);
            }
            catch
            {
                txtAnswer.Text = "Not valid data.";
                return;
            }

            answer = firstNum * secondNum;

            txtAnswer.Text = answer.ToString();
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            float firstNum;
            float secondNum;
            float answer;

            try
            {
                firstNum = float.Parse(txtFirst.Text);
                secondNum = float.Parse(txtSecond.Text);
            }
            catch
            {
                txtAnswer.Text = "Not valid data.";
                return;
            }

            answer = (firstNum * 2) + (secondNum * 2);

            txtAnswer.Text = answer.ToString();
        }
    }
}
