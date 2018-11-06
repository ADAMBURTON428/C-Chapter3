namespace GUIcalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblResultSub = new System.Windows.Forms.Label();
            this.lblResultMulti = new System.Windows.Forms.Label();
            this.lblResultDiv = new System.Windows.Forms.Label();
            this.lblResultMod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter another Number";
            // 
            // lblResultAdd
            // 
            this.lblResultAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultAdd.Location = new System.Drawing.Point(67, 214);
            this.lblResultAdd.Name = "lblResultAdd";
            this.lblResultAdd.Size = new System.Drawing.Size(100, 23);
            this.lblResultAdd.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(67, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(267, 67);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 4;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(267, 139);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 5;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(208, 250);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(453, 250);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(330, 250);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "Multiply";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(570, 250);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 9;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblResultSub
            // 
            this.lblResultSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultSub.Location = new System.Drawing.Point(192, 214);
            this.lblResultSub.Name = "lblResultSub";
            this.lblResultSub.Size = new System.Drawing.Size(100, 23);
            this.lblResultSub.TabIndex = 10;
            // 
            // lblResultMulti
            // 
            this.lblResultMulti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMulti.Location = new System.Drawing.Point(321, 214);
            this.lblResultMulti.Name = "lblResultMulti";
            this.lblResultMulti.Size = new System.Drawing.Size(100, 23);
            this.lblResultMulti.TabIndex = 11;
            // 
            // lblResultDiv
            // 
            this.lblResultDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultDiv.Location = new System.Drawing.Point(440, 214);
            this.lblResultDiv.Name = "lblResultDiv";
            this.lblResultDiv.Size = new System.Drawing.Size(100, 23);
            this.lblResultDiv.TabIndex = 12;
            // 
            // lblResultMod
            // 
            this.lblResultMod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMod.Location = new System.Drawing.Point(555, 214);
            this.lblResultMod.Name = "lblResultMod";
            this.lblResultMod.Size = new System.Drawing.Size(100, 23);
            this.lblResultMod.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultMod);
            this.Controls.Add(this.lblResultDiv);
            this.Controls.Add(this.lblResultMulti);
            this.Controls.Add(this.lblResultSub);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResultAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblResultSub;
        private System.Windows.Forms.Label lblResultMulti;
        private System.Windows.Forms.Label lblResultDiv;
        private System.Windows.Forms.Label lblResultMod;
    }
}

