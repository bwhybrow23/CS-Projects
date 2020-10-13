namespace Roman_Numeral_Converter
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
            this.txtToConvert = new System.Windows.Forms.TextBox();
            this.btnConvert1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtToConvert
            // 
            this.txtToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToConvert.Location = new System.Drawing.Point(210, 127);
            this.txtToConvert.Name = "txtToConvert";
            this.txtToConvert.Size = new System.Drawing.Size(337, 38);
            this.txtToConvert.TabIndex = 0;
            // 
            // btnConvert1
            // 
            this.btnConvert1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConvert1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert1.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnConvert1.Location = new System.Drawing.Point(316, 218);
            this.btnConvert1.Name = "btnConvert1";
            this.btnConvert1.Size = new System.Drawing.Size(117, 35);
            this.btnConvert1.TabIndex = 2;
            this.btnConvert1.Text = "Convert";
            this.btnConvert1.UseVisualStyleBackColor = true;
            this.btnConvert1.Click += new System.EventHandler(this.btnConvert1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.title.Location = new System.Drawing.Point(177, 64);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(422, 37);
            this.title.TabIndex = 3;
            this.title.Text = "Roman Numeral Converter";
            // 
            // txtConverted
            // 
            this.txtConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConverted.Location = new System.Drawing.Point(210, 304);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(337, 38);
            this.txtConverted.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnConvert1);
            this.Controls.Add(this.txtToConvert);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToConvert;
        private System.Windows.Forms.Button btnConvert1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtConverted;
    }
}

