using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7
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

        private void lblEnter_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "") //checks for empty value
            {
                MessageBox.Show("Please enter the terms");
            }
            else
            {
                double PI; //for calculate pi value
                int i, denom; //denomnator
                int terms; //terms for input the integer terms
                terms = Convert.ToInt32(txtInput.Text);
                // initialize the variables PI and base
                PI = 0;
                denom = 1;
                // use a loop to calculate value of PI
                for (i = 1; i <= terms; i++) //loop up to terms
                {
                    PI = PI + 4 * Math.Pow(-1, (i - 1)) / denom;
                    denom = denom + 2;
                } // end loop
                  // print approximate value of PI
                lblValue.Text = "Approximate value of pi after " + terms;
                lblResult.Text = "= " + PI;
                // prompt the user to enter the repetition choice count « "\nEnter 'y/Y' to repeat the calculation for new n: "; cin » choice; cout « endl;
            }
        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
