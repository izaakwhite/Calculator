namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private TextBox GetTextBoxOutput()
        {
            return textBoxOutput;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonDecimal = new Button();
            buttonEquals = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMulti = new Button();
            buttonDivision = new Button();
            buttonLeftPara = new Button();
            buttonRightPara = new Button();
            buttonClearLast = new Button();
            buttonClearAll = new Button();
            panel1 = new Panel();
            textBoxOutput = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(32, 236);
            button1.Name = "button1";
            button1.Size = new Size(120, 120);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(158, 236);
            button2.Name = "button2";
            button2.Size = new Size(120, 120);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Font = new Font("Segoe UI", 16F);
            button3.Location = new Point(283, 236);
            button3.Name = "button3";
            button3.Size = new Size(120, 120);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Font = new Font("Segoe UI", 16F);
            button4.Location = new Point(32, 362);
            button4.Name = "button4";
            button4.Size = new Size(120, 120);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.Font = new Font("Segoe UI", 16F);
            button5.Location = new Point(158, 362);
            button5.Name = "button5";
            button5.Size = new Size(120, 120);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.Font = new Font("Segoe UI", 16F);
            button6.Location = new Point(283, 362);
            button6.Name = "button6";
            button6.Size = new Size(120, 120);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Gainsboro;
            button7.Font = new Font("Segoe UI", 16F);
            button7.Location = new Point(32, 488);
            button7.Name = "button7";
            button7.Size = new Size(120, 120);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Gainsboro;
            button8.Font = new Font("Segoe UI", 16F);
            button8.Location = new Point(158, 488);
            button8.Name = "button8";
            button8.Size = new Size(120, 120);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gainsboro;
            button9.Font = new Font("Segoe UI", 16F);
            button9.Location = new Point(283, 488);
            button9.Name = "button9";
            button9.Size = new Size(120, 120);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.Gainsboro;
            button0.Font = new Font("Segoe UI", 16F);
            button0.Location = new Point(32, 614);
            button0.Name = "button0";
            button0.Size = new Size(120, 120);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.BackColor = Color.Gainsboro;
            buttonDecimal.Font = new Font("Segoe UI", 16F);
            buttonDecimal.Location = new Point(158, 614);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(120, 120);
            buttonDecimal.TabIndex = 10;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = false;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.Gainsboro;
            buttonEquals.Font = new Font("Segoe UI", 16F);
            buttonEquals.Location = new Point(283, 614);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(120, 120);
            buttonEquals.TabIndex = 11;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.Silver;
            buttonPlus.Font = new Font("Segoe UI", 18F);
            buttonPlus.Location = new Point(409, 614);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(120, 120);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.Silver;
            buttonMinus.Font = new Font("Segoe UI", 18F);
            buttonMinus.Location = new Point(409, 488);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(120, 120);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "−";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = Color.Silver;
            buttonMulti.Font = new Font("Segoe UI", 18F);
            buttonMulti.Location = new Point(409, 362);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(120, 120);
            buttonMulti.TabIndex = 14;
            buttonMulti.Text = "×";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = Color.Silver;
            buttonDivision.Font = new Font("Segoe UI", 18F);
            buttonDivision.Location = new Point(409, 236);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(120, 120);
            buttonDivision.TabIndex = 15;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonLeftPara
            // 
            buttonLeftPara.BackColor = Color.Silver;
            buttonLeftPara.Font = new Font("Segoe UI", 16F);
            buttonLeftPara.Location = new Point(409, 110);
            buttonLeftPara.Name = "buttonLeftPara";
            buttonLeftPara.Size = new Size(120, 120);
            buttonLeftPara.TabIndex = 16;
            buttonLeftPara.Text = ")";
            buttonLeftPara.UseVisualStyleBackColor = false;
            buttonLeftPara.Click += buttonLeftPara_Click;
            // 
            // buttonRightPara
            // 
            buttonRightPara.BackColor = Color.Silver;
            buttonRightPara.Font = new Font("Segoe UI", 16F);
            buttonRightPara.Location = new Point(283, 110);
            buttonRightPara.Name = "buttonRightPara";
            buttonRightPara.Size = new Size(120, 120);
            buttonRightPara.TabIndex = 17;
            buttonRightPara.Text = "(";
            buttonRightPara.UseVisualStyleBackColor = false;
            buttonRightPara.Click += buttonRightPara_Click;
            // 
            // buttonClearLast
            // 
            buttonClearLast.BackColor = Color.DarkOrange;
            buttonClearLast.Font = new Font("Segoe UI", 16F);
            buttonClearLast.Location = new Point(32, 110);
            buttonClearLast.Name = "buttonClearLast";
            buttonClearLast.Size = new Size(120, 120);
            buttonClearLast.TabIndex = 18;
            buttonClearLast.Text = "C";
            buttonClearLast.UseVisualStyleBackColor = false;
            buttonClearLast.Click += buttonClearLast_Click;
            // 
            // buttonClearAll
            // 
            buttonClearAll.BackColor = Color.DarkOrange;
            buttonClearAll.Font = new Font("Segoe UI", 16F);
            buttonClearAll.Location = new Point(158, 110);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(120, 120);
            buttonClearAll.TabIndex = 19;
            buttonClearAll.Text = "CE";
            buttonClearAll.UseVisualStyleBackColor = false;
            buttonClearAll.Click += buttonClearAll_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxOutput);
            panel1.Location = new Point(32, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 85);
            panel1.TabIndex = 20;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = Color.White;
            textBoxOutput.BorderStyle = BorderStyle.None;
            textBoxOutput.Enabled = false;
            textBoxOutput.Font = new Font("Segoe UI", 16F);
            textBoxOutput.Location = new Point(14, 24);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(480, 36);
            textBoxOutput.TabIndex = 0;
            textBoxOutput.TextAlign = HorizontalAlignment.Right;
            textBoxOutput.TextChanged += TextBoxOutput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 758);
            Controls.Add(panel1);
            Controls.Add(buttonClearAll);
            Controls.Add(buttonClearLast);
            Controls.Add(buttonRightPara);
            Controls.Add(buttonLeftPara);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMulti);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDecimal);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonDecimal;
        private Button buttonEquals;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMulti;
        private Button buttonDivision;
        private Button buttonLeftPara;
        private Button buttonRightPara;
        private Button buttonClearLast;
        private Button buttonClearAll;
        private Panel panel1;
        private TextBox textBoxOutput;
    }
}
