﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKiloMeterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double miles;
            double kilometers;
            miles = Convert.ToInt32(txtMiles.Text);

            kilometers = 1.6 * miles;

            lblKilometers.Text = " " + kilometers;
        }
    }
}
