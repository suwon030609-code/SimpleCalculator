namespace SimpleCalculator
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtHistory = new TextBox();
            txtDisplay = new TextBox();
            button1 = new Button();
            btn0 = new Button();
            button3 = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            button12 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 31.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.GrayText;
            lblTitle.Location = new Point(253, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 96);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Calculator";
            // 
            // txtHistory
            // 
            txtHistory.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtHistory.Location = new Point(253, 153);
            txtHistory.Name = "txtHistory";
            txtHistory.ReadOnly = true;
            txtHistory.Size = new Size(722, 57);
            txtHistory.TabIndex = 1;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtDisplay.Location = new Point(253, 243);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(722, 78);
            txtDisplay.TabIndex = 2;
            txtDisplay.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(253, 733);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "+/-";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.Highlight;
            btn0.Location = new Point(439, 733);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 46);
            btn0.TabIndex = 4;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.Location = new Point(625, 733);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 5;
            button3.Text = ".";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("맑은 고딕", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnEqual.Location = new Point(825, 733);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(150, 46);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.Highlight;
            btn1.Location = new Point(253, 646);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 46);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.Highlight;
            btn2.Location = new Point(439, 646);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 46);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.Highlight;
            btn3.Location = new Point(625, 646);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 46);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("맑은 고딕", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnPlus.Location = new Point(825, 646);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(150, 46);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.Highlight;
            btn4.Location = new Point(253, 557);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 46);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.Highlight;
            btn5.Location = new Point(439, 557);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 46);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.Highlight;
            btn6.Location = new Point(625, 557);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 46);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // button12
            // 
            button12.Font = new Font("굴림", 10.875F);
            button12.Location = new Point(825, 557);
            button12.Name = "button12";
            button12.Size = new Size(150, 46);
            button12.TabIndex = 14;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.Highlight;
            btn7.Location = new Point(253, 473);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 46);
            btn7.TabIndex = 15;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.Highlight;
            btn8.Location = new Point(439, 473);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 46);
            btn8.TabIndex = 16;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("굴림", 10.875F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.Highlight;
            btn9.Location = new Point(625, 473);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 46);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // button16
            // 
            button16.Font = new Font("굴림", 10.875F);
            button16.Location = new Point(825, 473);
            button16.Name = "button16";
            button16.Size = new Size(150, 46);
            button16.TabIndex = 18;
            button16.Text = "×";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("굴림", 10.875F);
            button17.Location = new Point(253, 393);
            button17.Name = "button17";
            button17.Size = new Size(150, 46);
            button17.TabIndex = 19;
            button17.Text = "CE";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("굴림", 10.875F);
            button18.Location = new Point(439, 393);
            button18.Name = "button18";
            button18.Size = new Size(150, 46);
            button18.TabIndex = 20;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Font = new Font("굴림", 10.875F);
            button19.Location = new Point(625, 393);
            button19.Name = "button19";
            button19.Size = new Size(150, 46);
            button19.TabIndex = 21;
            button19.Text = "del";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Font = new Font("굴림", 10.875F);
            button20.Location = new Point(825, 393);
            button20.Name = "button20";
            button20.Size = new Size(150, 46);
            button20.TabIndex = 22;
            button20.Text = "÷";
            button20.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 929);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(button12);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(button3);
            Controls.Add(btn0);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Controls.Add(txtHistory);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Calculator v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtHistory;
        private TextBox txtDisplay;
        private Button button1;
        private Button btn0;
        private Button button3;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button button12;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}
