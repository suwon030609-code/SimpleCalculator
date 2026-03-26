namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string firstInput = "";
        private string secondInput = "";
        private string currentOperator = "";
        private bool isResultShown = false;
        public Form1()
        {
            InitializeComponent();

            txtHistory.Text = "";
            txtDisplay.Text = "0";

            this.KeyPreview = true;
        }
        private void UpdateScreen()
        {

            if (currentOperator == "")
            {
                txtHistory.Text = firstInput;
                txtDisplay.Text = firstInput == "" ? "0" : firstInput;
            }
            else
            {
                txtHistory.Text = $"{firstInput} {GetDisplayOperator(currentOperator)} {secondInput}".Trim();

                if (secondInput == "")
                    txtDisplay.Text = firstInput == "" ? "0" : firstInput;
                else
                    txtDisplay.Text = secondInput;
            }

        }
        private string FormatNumber(double value)
        {
            return value.ToString("0.###############");
        }

        private string GetDisplayOperator(string op)
        {
            if (op == "*") return "×";
            if (op == "/") return "÷";
            return op;
        }

        private string GetCurrentInput()
        {
            return currentOperator == "" ? firstInput : secondInput;
        }

        private void SetCurrentInput(string value)
        {
            if (currentOperator == "")
                firstInput = value;
            else
                secondInput = value;
        }
        private void AppendDigit(string digit)
        {
            if (isResultShown && currentOperator == "")
            {
                firstInput = "";
                isResultShown = false;
            }

            string current = GetCurrentInput();

            if (current == "0")
                current = digit;
            else if (current == "-0")
                current = "-" + digit;
            else
                current += digit;

            SetCurrentInput(current);
            UpdateScreen();
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            AppendDigit(clickedButton.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            CalculateInternal();
        }
        private void SetOperator(string op)
        {
            if (firstInput == "")
                return;

            isResultShown = false;

            if (currentOperator != "" && secondInput == "")
            {
                currentOperator = op;
                UpdateScreen();
                return;
            }

            if (currentOperator != "" && secondInput != "")
            {
                if (!CalculateInternal())
                    return;
            }

            currentOperator = op;
            isResultShown = false;
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
            isResultShown = false;

            txtHistory.Text = "";
            txtDisplay.Text = "0";
        }
        private void ClearEntry()
        {
            if (currentOperator == "")
                firstInput = "";
            else
                secondInput = "";

            isResultShown = false;
            UpdateScreen();
        }
        private void DeleteLastChar()
        {
            string current = GetCurrentInput();

            if (current.Length == 0)
                return;

            current = current.Substring(0, current.Length - 1);

            if (current == "-")
                current = "";

            SetCurrentInput(current);
            isResultShown = false;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateInternal();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                DeleteLastChar();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                ClearAll();
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                AppendDigit(e.KeyChar.ToString());
                e.Handled = true;
                return;
            }

            switch (e.KeyChar)
            {
                case '+':
                    SetOperator("+");
                    e.Handled = true;
                    break;
                case '-':
                    SetOperator("-");
                    e.Handled = true;
                    break;
                case '*':
                case 'x':
                case 'X':
                    SetOperator("*");
                    e.Handled = true;
                    break;
                case '/':
                    SetOperator("/");
                    e.Handled = true;
                    break;
                case '.':
                    AppendDot();
                    e.Handled = true;
                    break;
                case '=':
                    CalculateInternal();
                    e.Handled = true;
                    break;
            }
        }
        private void AppendDot()
        {
            if (isResultShown && currentOperator == "")
            {
                firstInput = "";
                isResultShown = false;
            }

            string current = GetCurrentInput();

            if (current == "")
                current = "0";

            if (!current.Contains("."))
            {
                current += ".";
                SetCurrentInput(current);
                UpdateScreen();
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            AppendDot();
        }
        private void ToggleSign()
        {
            string current = GetCurrentInput();

            if (current == "" || current == "0")
                return;

            if (current.StartsWith("-"))
                current = current.Substring(1);
            else
                current = "-" + current;

            SetCurrentInput(current);
            UpdateScreen();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            ToggleSign();
        }
        private bool CalculateInternal()
        {
            if (firstInput == "" || secondInput == "" || currentOperator == "")
                return false;

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
                        return false;
                    }
                    result = n1 / n2;
                    break;
            }

            string resultText = FormatNumber(result);
            string expression = $"{firstInput} {GetDisplayOperator(currentOperator)} {secondInput} = {resultText}";

            txtHistory.Text = expression;
            txtDisplay.Text = resultText;

            firstInput = resultText;
            secondInput = "";
            currentOperator = "";
            isResultShown = true;

            return true;
        }
    }
}
