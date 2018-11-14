namespace PayRollGUI
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
            this.btnPayRoll = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtSocialSecurity = new System.Windows.Forms.TextBox();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblFederal = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayRoll
            // 
            this.btnPayRoll.Location = new System.Drawing.Point(293, 173);
            this.btnPayRoll.Name = "btnPayRoll";
            this.btnPayRoll.Size = new System.Drawing.Size(75, 23);
            this.btnPayRoll.TabIndex = 0;
            this.btnPayRoll.Text = "PayRoll";
            this.btnPayRoll.UseVisualStyleBackColor = true;
            this.btnPayRoll.Click += new System.EventHandler(this.btnPayRoll_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(141, 206);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 2;
            // 
            // txtSocialSecurity
            // 
            this.txtSocialSecurity.Location = new System.Drawing.Point(141, 153);
            this.txtSocialSecurity.Name = "txtSocialSecurity";
            this.txtSocialSecurity.Size = new System.Drawing.Size(100, 20);
            this.txtSocialSecurity.TabIndex = 3;
            this.txtSocialSecurity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(141, 180);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyPay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Social Sercurity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Hourly Pay Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Hours Worked";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPay.Location = new System.Drawing.Point(525, 127);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(100, 23);
            this.lblGrossPay.TabIndex = 9;
            // 
            // lblNet
            // 
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNet.Location = new System.Drawing.Point(525, 209);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(100, 23);
            this.lblNet.TabIndex = 11;
            // 
            // lblFederal
            // 
            this.lblFederal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFederal.Location = new System.Drawing.Point(525, 157);
            this.lblFederal.Name = "lblFederal";
            this.lblFederal.Size = new System.Drawing.Size(100, 23);
            this.lblFederal.TabIndex = 12;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(525, 183);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(100, 23);
            this.lblState.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "GrossPay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Federal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(468, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Net";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFederal);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHourlyPay);
            this.Controls.Add(this.txtSocialSecurity);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPayRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayRoll;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtSocialSecurity;
        private System.Windows.Forms.TextBox txtHourlyPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblFederal;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

