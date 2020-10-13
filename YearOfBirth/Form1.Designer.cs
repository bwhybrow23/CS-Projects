namespace YearOfBirth
{
    partial class YearOfBirth
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
            this.label1 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.chkHadBirthday = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yearrofBirth = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(187, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year of Birth Calculator";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(222, 149);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(128, 29);
            this.Age.TabIndex = 1;
            this.Age.Text = "Your Age:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(356, 147);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(199, 31);
            this.txtAge.TabIndex = 2;
            // 
            // chkHadBirthday
            // 
            this.chkHadBirthday.AutoSize = true;
            this.chkHadBirthday.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHadBirthday.Checked = true;
            this.chkHadBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHadBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHadBirthday.Location = new System.Drawing.Point(227, 195);
            this.chkHadBirthday.Name = "chkHadBirthday";
            this.chkHadBirthday.Size = new System.Drawing.Size(328, 24);
            this.chkHadBirthday.TabIndex = 3;
            this.chkHadBirthday.Text = "Have you had your birthday this year?";
            this.chkHadBirthday.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yearrofBirth
            // 
            this.yearrofBirth.AutoSize = true;
            this.yearrofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearrofBirth.Location = new System.Drawing.Point(221, 349);
            this.yearrofBirth.Name = "yearrofBirth";
            this.yearrofBirth.Size = new System.Drawing.Size(186, 31);
            this.yearrofBirth.TabIndex = 5;
            this.yearrofBirth.Text = "Year of Birth:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(404, 352);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(26, 29);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "0";
            // 
            // YearOfBirth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.yearrofBirth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkHadBirthday);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label1);
            this.Name = "YearOfBirth";
            this.Text = "YearOfBirth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.CheckBox chkHadBirthday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label yearrofBirth;
        private System.Windows.Forms.Label lblOutput;
    }
}

