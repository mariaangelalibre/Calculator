using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn3.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn3.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn2.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn2.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn1.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn1.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn6.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn6.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn5.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn5.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn4.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn4.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn9.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn9.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn8.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn8.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Text = btn7.Text;
            }
            else
            {
                txtbx.Text = txtbx.Text + btn7.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtbx.Text != "0")
            {
                txtbx.Text = txtbx.Text + btn0.Text;
            }
        }
       
        private void btnce_Click(object sender, EventArgs e)
        {
            txtbx.Text = "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtbx.Text = "0";
            lbl.Text = "";
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            String num1 = txtbx.Text;

        }

        private void arithmetic(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lbl.Text = lbl.Text + txtbx.Text + btn.Text;
        }
    }
}
