namespace Car_calc
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inTxtCarRepairs = new System.Windows.Forms.TextBox();
            this.inTxtCarOil = new System.Windows.Forms.TextBox();
            this.inTxtCarRegistration = new System.Windows.Forms.TextBox();
            this.inTxtCarGas = new System.Windows.Forms.TextBox();
            this.inTxtCarInsurance = new System.Windows.Forms.TextBox();
            this.inTxtCarNote = new System.Windows.Forms.TextBox();
            this.outTxtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(203, 371);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 41);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.submitExpenses);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Insurance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Oil Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Basic Repairs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Registration Fees";
            // 
            // inTxtCarRepairs
            // 
            this.inTxtCarRepairs.Location = new System.Drawing.Point(178, 285);
            this.inTxtCarRepairs.Name = "inTxtCarRepairs";
            this.inTxtCarRepairs.Size = new System.Drawing.Size(139, 31);
            this.inTxtCarRepairs.TabIndex = 12;
            // 
            // inTxtCarOil
            // 
            this.inTxtCarOil.Location = new System.Drawing.Point(157, 205);
            this.inTxtCarOil.Name = "inTxtCarOil";
            this.inTxtCarOil.Size = new System.Drawing.Size(160, 31);
            this.inTxtCarOil.TabIndex = 13;
            // 
            // inTxtCarRegistration
            // 
            this.inTxtCarRegistration.Location = new System.Drawing.Point(215, 334);
            this.inTxtCarRegistration.Name = "inTxtCarRegistration";
            this.inTxtCarRegistration.Size = new System.Drawing.Size(102, 31);
            this.inTxtCarRegistration.TabIndex = 14;
            // 
            // inTxtCarGas
            // 
            this.inTxtCarGas.Location = new System.Drawing.Point(81, 147);
            this.inTxtCarGas.Name = "inTxtCarGas";
            this.inTxtCarGas.Size = new System.Drawing.Size(236, 31);
            this.inTxtCarGas.TabIndex = 15;
            // 
            // inTxtCarInsurance
            // 
            this.inTxtCarInsurance.Location = new System.Drawing.Point(178, 93);
            this.inTxtCarInsurance.Name = "inTxtCarInsurance";
            this.inTxtCarInsurance.Size = new System.Drawing.Size(139, 31);
            this.inTxtCarInsurance.TabIndex = 16;
            // 
            // inTxtCarNote
            // 
            this.inTxtCarNote.Location = new System.Drawing.Point(138, 24);
            this.inTxtCarNote.Name = "inTxtCarNote";
            this.inTxtCarNote.Size = new System.Drawing.Size(179, 31);
            this.inTxtCarNote.TabIndex = 17;
            // 
            // outTxtResults
            // 
            this.outTxtResults.Location = new System.Drawing.Point(17, 418);
            this.outTxtResults.Multiline = true;
            this.outTxtResults.Name = "outTxtResults";
            this.outTxtResults.Size = new System.Drawing.Size(300, 100);
            this.outTxtResults.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 529);
            this.Controls.Add(this.outTxtResults);
            this.Controls.Add(this.inTxtCarNote);
            this.Controls.Add(this.inTxtCarInsurance);
            this.Controls.Add(this.inTxtCarGas);
            this.Controls.Add(this.inTxtCarRegistration);
            this.Controls.Add(this.inTxtCarOil);
            this.Controls.Add(this.inTxtCarRepairs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "AutoCosts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inTxtCarRepairs;
        private System.Windows.Forms.TextBox inTxtCarOil;
        private System.Windows.Forms.TextBox inTxtCarRegistration;
        private System.Windows.Forms.TextBox inTxtCarGas;
        private System.Windows.Forms.TextBox inTxtCarInsurance;
        private System.Windows.Forms.TextBox inTxtCarNote;
        private System.Windows.Forms.TextBox outTxtResults;
    }
}

