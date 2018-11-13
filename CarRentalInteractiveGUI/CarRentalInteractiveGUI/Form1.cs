using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int days;
            double miles;
            double Fee;
            days = Convert.ToInt32(txtDays.Text);
            miles = Convert.ToInt32(txtMiles.Text);


            Fee = (days * 20) + (miles * .25);

            lblFee.Text = "You fee is " + Fee.ToString("c"); 
            

        }
    }
}
