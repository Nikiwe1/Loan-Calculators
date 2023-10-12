namespace Loan_Calculators
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTerms = new System.Windows.Forms.Label();
            this.txtTermsInYears = new System.Windows.Forms.TextBox();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount:";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(517, 12);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(227, 26);
            this.txtLoanAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Down Payment:";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(517, 76);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(227, 26);
            this.txtDownPayment.TabIndex = 3;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(517, 135);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(227, 26);
            this.txtInterestRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interest Rate:";
            // 
            // txtTerms
            // 
            this.txtTerms.AutoSize = true;
            this.txtTerms.Location = new System.Drawing.Point(333, 196);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(115, 20);
            this.txtTerms.TabIndex = 6;
            this.txtTerms.Text = "Terms in years:";
            // 
            // txtTermsInYears
            // 
            this.txtTermsInYears.Location = new System.Drawing.Point(517, 190);
            this.txtTermsInYears.Name = "txtTermsInYears";
            this.txtTermsInYears.Size = new System.Drawing.Size(227, 26);
            this.txtTermsInYears.TabIndex = 7;
            // 
            // btnMortgage
            // 
            this.btnMortgage.Location = new System.Drawing.Point(498, 249);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(102, 34);
            this.btnMortgage.TabIndex = 8;
            this.btnMortgage.Text = "Mortgage";
            this.btnMortgage.UseVisualStyleBackColor = true;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(651, 249);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 34);
            this.btnAuto.TabIndex = 9;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(248, 306);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(130, 20);
            this.lblMonthlyPayment.TabIndex = 10;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.txtTermsInYears);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Loan Calculators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTerms;
        private System.Windows.Forms.TextBox txtTermsInYears;
        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lblMonthlyPayment;
    }
}

