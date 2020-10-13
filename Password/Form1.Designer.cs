namespace Password
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pwLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Orchid;
            this.txtPassword.Location = new System.Drawing.Point(197, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(416, 29);
            this.txtPassword.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(197, 336);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(416, 29);
            this.txtResult.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(326, 199);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 55);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Log In";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLabel.Location = new System.Drawing.Point(79, 136);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(112, 25);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(79, 92);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(116, 25);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsTab = true;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Orchid;
            this.txtUsername.Location = new System.Drawing.Point(197, 88);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(416, 29);
            this.txtUsername.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPassword);
            this.Name = "Form1";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

