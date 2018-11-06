using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            sum = num1 + num2;
            lblResultAdd.Text = "The sum is " + sum;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int differents;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            differents = num1 - num2;
            lblResultSub.Text = "The differents is " + differents;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int Product;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            Product = num1 * num2;
            lblResultMulti.Text = "The Product is " + Product;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int divided;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            divided = num1 / num2;
            lblResultDiv.Text = "Divided by " + divided;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int Mod;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            Mod = num1 % num2;
            lblResultMod.Text = "The Mod is " + Mod;
        }
    }
}
