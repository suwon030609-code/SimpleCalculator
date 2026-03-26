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
            btnSign = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnDel = new Button();
            btnDivide = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 31.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.GrayText;
            lblTitle.Location = new Point(27, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 96);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Calculator";
            // 
            // txtHistory
            // 
            txtHistory.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtHistory.Location = new Point(27, 181);
            txtHistory.Name = "txtHistory";
            txtHistory.ReadOnly = true;
            txtHistory.Size = new Size(722, 57);
            txtHistory.TabIndex = 1;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtDisplay.Location = new Point(27, 273);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(722, 78);
            txtDisplay.TabIndex = 2;
            txtDisplay.Text = "0";
            // 
            // btnSign
            // 
            btnSign.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnSign.Location = new Point(27, 829);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(150, 60);
            btnSign.TabIndex = 3;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.Highlight;
            btn0.Location = new Point(213, 829);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 60);
            btn0.TabIndex = 4;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnDot.Location = new Point(399, 829);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(150, 60);
            btnDot.TabIndex = 5;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnEqual.ForeColor = SystemColors.ControlText;
            btnEqual.Location = new Point(599, 829);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(150, 60);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.Highlight;
            btn1.Location = new Point(27, 724);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 60);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.Highlight;
            btn2.Location = new Point(213, 724);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 60);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.Highlight;
            btn3.Location = new Point(399, 724);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 60);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(599, 724);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(150, 60);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.Highlight;
            btn4.Location = new Point(27, 629);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 60);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.Highlight;
            btn5.Location = new Point(213, 629);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 60);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.Highlight;
            btn6.Location = new Point(399, 629);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 60);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnMinus.ForeColor = Color.Red;
            btnMinus.Location = new Point(599, 629);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(150, 60);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.Highlight;
            btn7.Location = new Point(27, 533);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 60);
            btn7.TabIndex = 15;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.Highlight;
            btn8.Location = new Point(213, 533);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 60);
            btn8.TabIndex = 16;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("굴림", 15F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.Highlight;
            btn9.Location = new Point(399, 533);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 60);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(599, 533);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(150, 60);
            btnMultiply.TabIndex = 18;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnCE.Location = new Point(27, 433);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(150, 60);
            btnCE.TabIndex = 19;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnC.Location = new Point(213, 433);
            btnC.Name = "btnC";
            btnC.Size = new Size(150, 60);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnDel.Location = new Point(399, 433);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 60);
            btnDel.TabIndex = 21;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("굴림", 15F, FontStyle.Bold);
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(599, 433);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(150, 60);
            btnDivide.TabIndex = 22;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 929);
            Controls.Add(btnDivide);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnSign);
            Controls.Add(txtDisplay);
            Controls.Add(txtHistory);
            Controls.Add(lblTitle);
            KeyPreview = true;
            Name = "Form1";
            Text = " ";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtHistory;
        private TextBox txtDisplay;
        private Button btnSign;
        private Button btn0;
        private Button btnDot;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btnCE;
        private Button btnC;
        private Button btnDel;
        private Button btnDivide;
    }
}
