using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {

            double Salary;
            double Raise;


            Salary = Convert.ToInt32(txtSalary.Text);

            Raise = Salary * 1.04;

            lblNewSalary.Text = "" + Raise.ToString("c");




        }
    }
}
