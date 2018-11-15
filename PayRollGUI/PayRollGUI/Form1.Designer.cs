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
            this.lblPayRoll = new System.Windows.Forms.Label();
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
            // lblPayRoll
            // 
            this.lblPayRoll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayRoll.Location = new System.Drawing.Point(447, 149);
            this.lblPayRoll.Name = "lblPayRoll";
            this.lblPayRoll.Size = new System.Drawing.Size(200, 73);
            this.lblPayRoll.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPayRoll);
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
        private System.Windows.Forms.Label lblPayRoll;
    }
}

