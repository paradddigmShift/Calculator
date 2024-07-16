using System;
using System.Data;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Form1 : Form
    {
        private double xValue = 0;
        private double yValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtInput.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtInput.Text;
                expression = expression.Replace("x", xValue.ToString());
                expression = expression.Replace("y", yValue.ToString());

                double result = EvaluateExpression(expression);
                txtOutput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txtOutput.Text = "Error";
            }
        }

        private double EvaluateExpression(string expression)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expression, "");
            return Convert.ToDouble(value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtInput.Text += "Math.Sqrt(";
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "x")
            {
                // Prompt for x value
                SetVariableValue("x", ref xValue);
                txtInput.Text += "x";
            }
            else if (btn.Text == "y")
            {
                // Prompt for y value
                SetVariableValue("y", ref yValue);
                txtInput.Text += "y";
            }
        }

        private void SetVariableValue(string variableName, ref double variable)
        {
            using (Form inputForm = new Form())
            {
                inputForm.Width = 300;
                inputForm.Height = 150;
                inputForm.Text = $"Enter value for {variableName}";

                Label label = new Label() { Left = 10, Top = 20, Text = $"Value for {variableName}:" };
                TextBox textBox = new TextBox() { Left = 120, Top = 20, Width = 150 };
                Button confirmation = new Button() { Text = "OK", Left = 190, Width = 80, Top = 50 };

                confirmation.Click += (sender, e) => { inputForm.Close(); };
                inputForm.Controls.Add(label);
                inputForm.Controls.Add(textBox);
                inputForm.Controls.Add(confirmation);
                inputForm.ShowDialog();

                if (double.TryParse(textBox.Text, out double value))
                {
                    variable = value;
                }
            }
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            txtInput.Text += $"f({xValue}, {yValue})";
        }
    }
}