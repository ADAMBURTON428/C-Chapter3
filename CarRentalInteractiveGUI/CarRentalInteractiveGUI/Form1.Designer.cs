namespace CarRentalInteractiveGUI
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
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(271, 98);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 0;
            this.btnTotal.Text = "Get Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblFee
            // 
            this.lblFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFee.Location = new System.Drawing.Point(472, 103);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(100, 23);
            this.lblFee.TabIndex = 1;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(143, 77);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 2;
            this.txtDays.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(143, 120);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter days for renting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the amount of miles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.btnTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

