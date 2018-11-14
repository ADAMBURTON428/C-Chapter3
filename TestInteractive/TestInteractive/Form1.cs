using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInteractive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int score1;
            int score2;
            int score3;
            int score4;
            int score5;
            double average;

            score1 = Convert.ToInt32(txtScore1.Text);
            score2 = Convert.ToInt32(txtScore2.Text);
            score3 = Convert.ToInt32(txtScore3.Text);
            score4 = Convert.ToInt32(txtScore4.Text);
            score5 = Convert.ToInt32(txtScore5.Text);

            average =(score1 + score2 + score3 + score4 + score5) / 5;

            lblAverage.Text = "The average is " + average; 





        }
    }
}
