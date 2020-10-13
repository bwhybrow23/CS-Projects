namespace Calculator
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnConcat = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(50, 101);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(276, 20);
            this.txtFirst.TabIndex = 0;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(384, 101);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(285, 20);
            this.txtSecond.TabIndex = 1;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(234, 314);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(295, 20);
            this.txtAnswer.TabIndex = 2;
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(97, 200);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(75, 23);
            this.btnConcat.TabIndex = 3;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(202, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(312, 200);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "Minus";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(423, 200);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(75, 23);
            this.btnTimes.TabIndex = 6;
            this.btnTimes.Text = "Times";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(537, 200);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(234, 260);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 8;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Location = new System.Drawing.Point(384, 260);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(75, 23);
            this.btnPerimeter.TabIndex = 9;
            this.btnPerimeter.Text = "Perimeter";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPerimeter;
    }
}

