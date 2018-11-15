using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
          
            int a;
            int b;
            int c;

            a = Convert.ToInt32(txtNumber.Text);
            b = Convert.ToInt32(txtAnotherNumber.Text);

            c = a - b;

            lblStory.Text = "The " + txtColor.Text + "  is the " + txtEst.Text + " Dragon of all.It has " + c + txtPluralBody.Text + ", and a " + txtAnimal.Text + " shaped like a " + txtNoun.Text + ". It loves to eat " + txtPluralNoun.Text + ", although it will feast on nearly anything.";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
