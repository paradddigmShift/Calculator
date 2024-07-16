namespace AdvancedCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button[] btnNumbers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnFunction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnNumbers = new System.Windows.Forms.Button[10];
            for (int i = 0; i < 10; i++)
            {
                this.btnNumbers[i] = new System.Windows.Forms.Button();
            }
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(260, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 38);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(260, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // btnNumbers
            // 
            for (int i = 0; i < 10; i++)
            {
                this.btnNumbers[i].Name = "btn" + i;
                this.btnNumbers[i].Size = new System.Drawing.Size(60, 40);
                this.btnNumbers[i].TabIndex = i + 2;
                this.btnNumbers[i].Text = i.ToString();
                this.btnNumbers[i].UseVisualStyleBackColor = true;
                this.btnNumbers[i].Click += new System.EventHandler(this.btn_Click);
            }
            // Set button locations manually
            this.btnNumbers[1].Location = new System.Drawing.Point(12, 80);
            this.btnNumbers[2].Location = new System.Drawing.Point(78, 80);
            this.btnNumbers[3].Location = new System.Drawing.Point(144, 80);
            this.btnNumbers[4].Location = new System.Drawing.Point(12, 130);
            this.btnNumbers[5].Location = new System.Drawing.Point(78, 130);
            this.btnNumbers[6].Location = new System.Drawing.Point(144, 130);
            this.btnNumbers[7].Location = new System.Drawing.Point(12, 180);
            this.btnNumbers[8].Location = new System.Drawing.Point(78, 180);
            this.btnNumbers[9].Location = new System.Drawing.Point(144, 180);
            this.btnNumbers[0].Location = new System.Drawing.Point(78, 230);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(210, 130);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 40);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(210, 180);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 40);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(210, 230);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 40);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(12, 230);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(60, 40);
            this.btnDecimal.TabIndex = 16;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(144, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(210, 280);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 40);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 40);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(144, 230);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(60, 40);
            this.btnSqrt.TabIndex = 27;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(12, 280);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(60, 40);
            this.btnX.TabIndex = 28;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(78, 280);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(60, 40);
            this.btnY.TabIndex = 29;
            this.btnY.Text = "y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(12, 330);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(126, 40);
            this.btnFunction.TabIndex = 30;
            this.btnFunction.Text = "f(x, y)";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(this.btnNumbers[i]);
            }
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnFunction);
            this.Name = "Form1";
            this.Text = "Advanced Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}