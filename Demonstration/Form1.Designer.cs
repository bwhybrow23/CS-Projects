namespace Demonstration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.click_me_button = new System.Windows.Forms.Button();
            this.input_text_box = new System.Windows.Forms.TextBox();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // click_me_button
            // 
            this.click_me_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_me_button.Location = new System.Drawing.Point(264, 171);
            this.click_me_button.Name = "click_me_button";
            this.click_me_button.Size = new System.Drawing.Size(222, 98);
            this.click_me_button.TabIndex = 0;
            this.click_me_button.Text = "CLICK ME!";
            this.click_me_button.UseVisualStyleBackColor = true;
            this.click_me_button.Click += new System.EventHandler(this.click_me_button_Click);
            // 
            // input_text_box
            // 
            this.input_text_box.Location = new System.Drawing.Point(239, 108);
            this.input_text_box.Name = "input_text_box";
            this.input_text_box.Size = new System.Drawing.Size(273, 20);
            this.input_text_box.TabIndex = 1;
            // 
            // web_browser
            // 
            this.web_browser.Location = new System.Drawing.Point(8, 12);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(780, 426);
            this.web_browser.TabIndex = 2;
            this.web_browser.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.web_browser);
            this.Controls.Add(this.input_text_box);
            this.Controls.Add(this.click_me_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click_me_button;
        private System.Windows.Forms.TextBox input_text_box;
        private System.Windows.Forms.WebBrowser web_browser;
    }
}

