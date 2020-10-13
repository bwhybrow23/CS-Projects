using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Demonstration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Timer Thingy
        public static void DelayAction(int millisecond, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate

            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }

        private void click_me_button_Click(object sender, EventArgs e)
        {
            string textInput = input_text_box.Text;

            if (textInput == "Rick Roll")
            {
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<video autoplay>";
                html += "<source src='{0}' type='video/mp4'>";
                html += "</video>";
                html += "</body></html>";
                web_browser.Show();
                this.web_browser.DocumentText = string.Format(html, "https://benwhybrow.com/rick_roll.mp4");

                DelayAction(212000, new Action(() => {
                    web_browser.Hide();
                    this.web_browser.DocumentText = "";
                }));
            }
            else
            {
                MessageBox.Show(textInput);
            }
        }
    }
}
