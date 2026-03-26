namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string firstInput = "";
        private string secondInput = "";
        private string currentOperator = "";

        private string lastOperator = "";
        private string lastSecondInput = "";
        private bool isCalculated = false;
        public Form1()
        {
            InitializeComponent();
            txtHistory.Text = "";
            txtDisplay.Text = "0";
        }
        private void UpdateScreen()
        {
            string displayOperator = currentOperator;

            if (currentOperator == "*")
                displayOperator = "×";
            else if (currentOperator == "/")
                displayOperator = "÷";

            if (currentOperator == "")
            {
                txtHistory.Text = firstInput;
                txtDisplay.Text = firstInput == "" ? "0" : firstInput;
            }
            else
            {
                txtHistory.Text = $"{firstInput} {displayOperator} {secondInput}".Trim();
                txtDisplay.Text = secondInput == "" ? firstInput : secondInput;
            }

            if (txtDisplay.Text == "")
                txtDisplay.Text = "0";

        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string digit = clickedButton.Text;

            if (currentOperator == "")
            {
                firstInput += digit;
            }
            else
            {
                secondInput += digit;
            }

            UpdateScreen();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (firstInput == "" || secondInput == "" || currentOperator == "")
                return;

            double n1 = double.Parse(firstInput);
            double n2 = double.Parse(secondInput);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        return;
                    }
                    result = n1 / n2;
                    break;
            }

            string displayOp = GetDisplayOperator();
            txtHistory.Text = $"{firstInput} {displayOp} {secondInput} = {result}";
            txtDisplay.Text = result.ToString();

            firstInput = result.ToString();
            secondInput = "";
            currentOperator = "";
        }
        private void SetOperator(string op)
        {
            if (firstInput == "")
                return;

            if (secondInput != "")
                return;

            currentOperator = op;
            UpdateScreen();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperator("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperator("/");
        }
        private string GetDisplayOperator()
        {
            if (currentOperator == "*")
                return "×";
            if (currentOperator == "/")
                return "÷";

            return currentOperator;
        }
        private void ClearAll()
        {
            firstInput = "";
            secondInput = "";
            currentOperator = "";

            txtHistory.Text = "";
            txtDisplay.Text = "0";
        }
        private void ClearEntry()
        {
            if (currentOperator == "")
            {
                firstInput = "";
            }
            else
            {
                secondInput = "";
            }

            UpdateScreen();
        }
        private void DeleteLastChar()
        {
            if (currentOperator == "")
            {
                if (firstInput.Length > 0)
                {
                    firstInput = firstInput.Substring(0, firstInput.Length - 1);
                }
            }
            else
            {
                if (secondInput.Length > 0)
                {
                    secondInput = secondInput.Substring(0, secondInput.Length - 1);
                }
            }

            UpdateScreen();
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteLastChar();
        }
        private string FormatNumber(double value)
        {
            return value.ToString("0.###############");
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
