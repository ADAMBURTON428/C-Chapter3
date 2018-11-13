namespace EggsInteractiveGUI
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken5 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(428, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(266, 23);
            this.lblTotal.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(290, 164);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Covert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(98, 106);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(100, 20);
            this.txtChicken1.TabIndex = 2;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(98, 132);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(100, 20);
            this.txtChicken2.TabIndex = 3;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(98, 158);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(100, 20);
            this.txtChicken3.TabIndex = 4;
            // 
            // txtChicken5
            // 
            this.txtChicken5.Location = new System.Drawing.Point(98, 210);
            this.txtChicken5.Name = "txtChicken5";
            this.txtChicken5.Size = new System.Drawing.Size(100, 20);
            this.txtChicken5.TabIndex = 6;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(98, 184);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(100, 20);
            this.txtChicken4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter the amount of eggs per chicken";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChicken5);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken5;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.Label label2;
    }
}

