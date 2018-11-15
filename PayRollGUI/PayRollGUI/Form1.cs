using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPayRoll_Click(object sender, EventArgs e)
        {
            String Name = (txtName.Text);
            int Security;
            int HourlyPay;
            int HoursWorked;
            double NetPay;
            double State;
            double Federal;
            double GrossPay;
            double Tax;
            
            HourlyPay = Convert.ToInt32(txtHourlyPay.Text);
            HoursWorked = Convert.ToInt32(txtHoursWorked.Text);
            Security = Convert.ToInt32(txtSocialSecurity.Text);

            GrossPay = HourlyPay * HoursWorked;
            Federal = GrossPay / 15;
            State = GrossPay / 5;
            Tax = Federal + State;
            NetPay = GrossPay - Tax;


            lblPayRoll.Text = "Hello " + Name + " Social Security( " + Security + ") , Gross Pay is " + GrossPay.ToString("c") + ". Federal is " + Federal.ToString("c") + " and State is " + State.ToString("c") + ".Your Net Pay is now " + NetPay.ToString("c");





        }
    }
}
