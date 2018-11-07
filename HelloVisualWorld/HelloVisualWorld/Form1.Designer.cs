namespace HelloVisualWorld
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnReally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(112, 141);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "ClickHere";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(109, 100);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(96, 13);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello Visual World!";
            this.lblHello.Visible = false;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(111, 205);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(94, 23);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = "Click Me Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReally
            // 
            this.btnReally.Location = new System.Drawing.Point(112, 252);
            this.btnReally.Name = "btnReally";
            this.btnReally.Size = new System.Drawing.Size(75, 48);
            this.btnReally.TabIndex = 3;
            this.btnReally.Text = "Click me Really Last";
            this.btnReally.UseVisualStyleBackColor = true;
            this.btnReally.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReally);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnReally;
    }
}

